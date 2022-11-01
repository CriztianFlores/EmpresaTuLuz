using EmpresaTuLuz.DAO;
using EmpresaTuLuz.Entidades;
using EmpresaTuLuz.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaTuLuz
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
            
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            cargarComboEmpleado();
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;

        }

        public void agregarUsuario(Usuario u)
        {
            DataGridViewRow fila = new DataGridViewRow();
            DataGridViewTextBoxCell celdaDocumento = new DataGridViewTextBoxCell();
            //celdaDocumento.Value = u.
        }

        

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
  
            Usuario u = new Usuario();

            ModificarUsuario modificarUsuario = new ModificarUsuario(u, 0);
            modificarUsuario.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            modificarUsuario.Show();
            
        }

        //Carga de componentes------------------------------------------------------------------------------

        private void cargarComboEmpleado()
        {

            DataTable tabla = EmpleadoDAO.obtenerTablaEmpleados();

         

                cbBuscarEmpleado.DataSource = tabla;
                cbBuscarEmpleado.DisplayMember = "empleado_id";
                cbBuscarEmpleado.ValueMember = "empleado_id";
                cbBuscarEmpleado.SelectedIndex = -1;


  
        }

        private void cargarGrilla()
        {
            int estado;
            if (rbtn_activos.Checked)
            {
                estado = 1;
            }
            else if (rbtn_inactivos.Checked)
            {
                estado = 0;
            }
            else
            {
                estado = 2;
            }
            grillaUsuarios.DataSource = UsuarioDAO.obtenerListadoUsuarios(estado);
        }

        private bool existeEnGrilla(string criterioABuscar)
        {
            bool resultado = false;
            for (int i = 0; i < grillaUsuarios.Rows.Count; i++)
            {
                if (grillaUsuarios.Rows[i].Cells["usuario_nombre"].Value.Equals(criterioABuscar))
                {
                    resultado = true;
                    break;
                }
            }
            return resultado;
        }

        private void grillaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice > -1)
            {
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                DataGridViewRow filaSeleccionada = grillaUsuarios.Rows[indice];
                int usuario = int.Parse(filaSeleccionada.Cells["usuario_id"].Value.ToString());
                Usuario u = UsuarioDAO.obtenerUsuarioById(usuario);
                cargarCampos(u);
            }
                
        }

      

        private void cargarCampos(Usuario u)
        {

            Empleado e = EmpleadoDAO.obtenerEmpleadoById(u.EmpleadoId);

            txtEmpleadoNombre.Text = e.Nombre;
            txtEmpleadoApellido.Text = e.Apellido;
            txtEmpleadoTipoDni.Text = (e.TipoDoc == "1") ? "DNI" : "Pasaporte";
            txtEmpleadoNumeroDni.Text = e.NumDoc;
            btnEliminar.Text = u.Activo == 0 ? "Habilitar" : "Eliminar";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = grillaUsuarios.Rows[grillaUsuarios.CurrentCell.RowIndex];
            int usuario = int.Parse(filaSeleccionada.Cells["usuario_id"].Value.ToString());
            Usuario u = UsuarioDAO.obtenerUsuarioById(usuario);

            ModificarUsuario modificarUsuario = new ModificarUsuario(u, usuario);
            modificarUsuario.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            modificarUsuario.Show();

        }
        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            cargarGrilla();
            cargarComboEmpleado();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int posicionSeleccionada = grillaUsuarios.CurrentRow.Index;
            DataGridViewRow filaSeleccionada = grillaUsuarios.Rows[posicionSeleccionada];
            int index = int.Parse(filaSeleccionada.Cells["usuario_id"].Value.ToString());
            string msg_confirmacion;
            int value;
            string msgExito;
            if ((filaSeleccionada.Cells["usuario_activo"].Value.ToString() == "1")) { 
             msg_confirmacion = "Seguro que desea eliminar el usuario: \n\n Nombre: " + filaSeleccionada.Cells["usuario_nombre"].Value.ToString() +
                "\n\n ID: " + filaSeleccionada.Cells["usuario_id"].Value.ToString();
                value = 0;
                msgExito = "Usuario eliminado con exito";
            }
            else {
                 msg_confirmacion = "Seguro que desea habilitar el usuario el usuario: \n\n Nombre: " + filaSeleccionada.Cells["usuario_nombre"].Value.ToString() +
                  "\n\n ID: " + filaSeleccionada.Cells["usuario_id"].Value.ToString() + " \n\n Si se habilita el usuario podra acceder nuevamente al sistema.";
                value = 1;
                msgExito = "Usuario habilitado con exito";
            }
            DialogResult dialogResult = MessageBox.Show(msg_confirmacion, "Confirmacion", MessageBoxButtons.YesNo);

            
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    bool resultado = UsuarioDAO.eliminarUsuario(index, value);
                    if (resultado)
                    {
                        MessageBox.Show(msgExito);
                     
                        cargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar usuario");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al eliminar usuario");
                }
            }
            
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int empleado_id = -3;
            if (cbBuscarEmpleado.SelectedIndex != -1)
            {
                empleado_id = (int)cbBuscarEmpleado.SelectedValue;

                grillaUsuarios.DataSource = obtenerListadoUsuariosEmpleado(empleado_id);

            }
            else
            {
                MessageBox.Show("Seleccione un empleado");
            }
        }

           
        public DataTable obtenerListadoUsuariosEmpleado(int index)
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM usuarios WHERE empleado_id LIKE @index";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@index",index);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void chkInactivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_todos_CheckedChanged(object sender, EventArgs e)
        {
            cargarGrilla();
        }
    }
}
