using EmpresaTuLuz.DAO;
using EmpresaTuLuz.Entidades;
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
            limpiarCampos();
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

        public bool esUsuarioValido(int parametro)
        {
            //Variables para los datos
            string nombreUser = txtUsuario.Text;
            string passUser = txtPassword.Text;
            int empleado_id = 0;
            byte estado;
            bool esInactivo = chkInactivo.Checked;
            if (esInactivo)
            {
                estado = 1;
            }
            else
            {
                estado = 0;
            }


            //Validar espacios en blanco
            bool tieneUsuario = false;
            bool tienePassword = false;
            bool tieneEmpleado = false;
            bool passCoinciden = false;
            bool existeEnLaGrilla = true;

            if (txtUsuario.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el nombre de usuario");
                txtUsuario.Focus();
            }
            else
            {
                tieneUsuario = true;
            }

            if (txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el password de usuario");
                txtPassword.Focus();
            }
            else
            {
                tienePassword = true;
            }

            if (!txtPassword.Text.Equals(txtRepetirPassword.Text))
            {
                MessageBox.Show("Las passwords no coinciden");
            }
            else
            {
                passCoinciden = true;
            }

            if (cbEmpleadoId.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el id del empleado asociado al nuevo usuario");
                cbEmpleadoId.Focus();
            }
            else
            {
                tieneEmpleado = true;
                empleado_id = (int)cbEmpleadoId.SelectedValue;
            }

            if (tieneUsuario && tienePassword && tieneEmpleado && passCoinciden)
            {
                //Validar existencia en grilla
                if(parametro != 1)
                {
                    existeEnLaGrilla = existeEnGrilla(nombreUser);
                }
                
                if (existeEnLaGrilla)
                {
                    if (parametro == 1)
                    {
                        return true;
                    }
                    MessageBox.Show("El usuario ingresado ya existe. Ingrese otro usuario");
                    limpiarCampos();
                    txtUsuario.Focus();
                }
            }
            return !existeEnLaGrilla;
        }
        

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (esUsuarioValido(0))
            {
                
                try
                {
                    int estado_invalido = 0;
                    //Crear usuario
                    if (chkInactivo.Checked)
                    {
                        estado_invalido = 1;
                    }
                    Usuario u = new Usuario(txtUsuario.Text, txtPassword.Text, (int)cbEmpleadoId.SelectedValue, estado_invalido);
                    bool resultado = UsuarioDAO.registrarUsuario(u);
                    if (resultado)
                    {
                        MessageBox.Show("Usuario registrado con exito");
                        limpiarCampos();
                        cargarGrilla();
                        txtUsuario.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar nuevo usuario");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al registrar nuevo usuario");
                    txtUsuario.Focus();
                }
            }
        }

        //Carga de componentes------------------------------------------------------------------------------

        private void cargarComboEmpleado()
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM empleados";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                DataTable tabla1 = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                da1.Fill(tabla1);

                cbEmpleadoId.DataSource = tabla;
                cbEmpleadoId.DisplayMember = "empleado_id";
                cbEmpleadoId.ValueMember = "empleado_id";
                cbEmpleadoId.SelectedIndex = -1;

                cbBuscarEmpleado.DataSource = tabla1;
                cbBuscarEmpleado.DisplayMember = "empleado_id";
                cbBuscarEmpleado.ValueMember = "empleado_id";
                cbBuscarEmpleado.SelectedIndex = -1;


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

        private void cargarGrilla()
        {
            grillaUsuarios.DataSource = UsuarioDAO.obtenerListadoUsuarios();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            
            txtUsuario.Text = "";
            txtPassword.Text = "";
            txtRepetirPassword.Text = "";
            chkInactivo.Checked = false;
            cbEmpleadoId.SelectedIndex = -1;

            if (btnActualizar.Enabled)
            {
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
                btnAgregarUsuario.Enabled = true;
            }
            
        }

        private void grillaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice > -1)
            {
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                btnAgregarUsuario.Enabled = false;
                DataGridViewRow filaSeleccionada = grillaUsuarios.Rows[indice];
                string usuario = filaSeleccionada.Cells["usuario_nombre"].Value.ToString();
                Usuario u = obtenerUsuario(usuario);
                cargarCampos(u);
            }
                
        }

        private Usuario obtenerUsuario(string usuario)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Usuario u = new Usuario();
            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM usuarios WHERE usuario_nombre like @usuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usuario",usuario);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();
                if(dr != null && dr.Read())
                {
                    u.Username = dr["usuario_nombre"].ToString();
                    u.Password = dr["usuario_pass"].ToString();
                    u.EmpleadoId = int.Parse(dr["empleado_id"].ToString());
                    u.Activo = int.Parse(dr["usuario_activo"].ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return u;
        }


        private void cargarCampos(Usuario u)
        {
            txtUsuario.Text = u.Username;
            txtPassword.Text = u.Password;
            txtRepetirPassword.Text = u.Password;
            cbEmpleadoId.SelectedValue = u.EmpleadoId;
            if(u.Activo == 0)
            {
                chkInactivo.Checked = true;
            }
            else
            {
                chkInactivo.Checked = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea realmente modificar al usuario?", "Confirmacion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (esUsuarioValido(1))
                {

                    try
                    {
                        int estado_invalido = 0;
                        int posicionSeleccionada = grillaUsuarios.CurrentRow.Index;
                        DataGridViewRow filaSeleccionada = grillaUsuarios.Rows[posicionSeleccionada];
                        int index = int.Parse(filaSeleccionada.Cells["usuario_id"].Value.ToString());
                        //Crear usuario
                        if (chkInactivo.Checked)
                        {
                            estado_invalido = 1;
                        }
                        Usuario u = new Usuario(txtUsuario.Text, txtPassword.Text, (int)cbEmpleadoId.SelectedValue, estado_invalido);
                        bool resultado = UsuarioDAO.actualizarUsuario(u, index);
                        if (resultado)
                        {
                            MessageBox.Show("Usuario modificado con exito");
                            limpiarCampos();
                            cargarGrilla();
                            txtUsuario.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Error al modificar usuario");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al modificar usuario");
                        txtUsuario.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("No pasa nada");
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Desea realmente eliminar al usuario?", "Confirmacion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    int posicionSeleccionada = grillaUsuarios.CurrentRow.Index;
                    DataGridViewRow filaSeleccionada = grillaUsuarios.Rows[posicionSeleccionada];
                    int index = int.Parse(filaSeleccionada.Cells["usuario_id"].Value.ToString());


                    bool resultado = UsuarioDAO.eliminarUsuario(index);
                    if (resultado)
                    {
                        MessageBox.Show("Usuario eliminado con exito");
                        limpiarCampos();
                        cargarGrilla();
                        txtUsuario.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar usuario");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al eliminar usuario");
                    txtUsuario.Focus();
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
    }
}
