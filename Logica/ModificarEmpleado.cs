using EmpresaTuLuz.DAO;
using EmpresaTuLuz.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaTuLuz.Logica
{
    public partial class ModificarEmpleado : Form
    {
        //Empleado empl;
        int idEmpl;
        //int parametroValidacion = 1;
        public ModificarEmpleado()
        {

        }
        public ModificarEmpleado(int id)
        {
            //empl=e;
            idEmpl = id;
            Empleado empl = EmpleadoDAO.obtenerEmpleadoById(idEmpl);
            bool isNewUser = empl.Nombre == null;
            InitializeComponent();
            if (!isNewUser)
            {
                cargarCampos(empl);
                //parametroValidacion = 2;

            }

        }

        private void cargarCampos(Empleado e)
        {

            Empleado em = EmpleadoDAO.obtenerEmpleadoById(e.Id);

            txtNombre.Text = em.Nombre;
            txtApellido.Text = em.Apellido;
            cmbTipoDoc.SelectedValue = int.Parse(em.TipoDoc);
            txtNumDoc.Text = em.NumDoc;
            txtDireccion.Text = em.Direccion;
            cmbBarrio.SelectedValue = em.IdBarrio;
            txtTelefono.Text = em.Telefono;
            txtId.Text = em.Id.ToString();
            txtEstado.Text = EstadoEmpleado(em.Activo);
            cmbTipoDoc.SelectedValue = em.JefeId;


        }

        private string EstadoEmpleado(bool estado)
        {

            string resultado = "";
            if (estado)
            {
                resultado = "Activo";

            }
            else
            {
                resultado = "Inactivo";
            }
            return resultado;

        }
        private void CargarComboTipoDocumento()
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM tipos_doc";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbTipoDoc.DataSource = tabla;
                cmbTipoDoc.DisplayMember = "siglas";
                cmbTipoDoc.ValueMember = "tipo_doc_id";
                cmbTipoDoc.SelectedIndex = -1;

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
        private void CargarComboBarrio()
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM barrios";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbBarrio.DataSource = tabla;
                cmbBarrio.DisplayMember = "nombre";
                cmbBarrio.ValueMember = "barrio_id";
                cmbBarrio.SelectedIndex = -1;

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
        private void CargarComboIdJefe()
        {
            DataTable tabla = EmpleadoDAO.obtenerListadoEmpleadosActivos();

            cmbIdJefe.DataSource = tabla;
            cmbIdJefe.DisplayMember = "empleado_id";
            cmbIdJefe.ValueMember = "empleado_id";
            cmbIdJefe.SelectedIndex = -1;

        }
        private void CargarCombos()
        {
            CargarComboTipoDocumento();
            CargarComboBarrio();
            CargarComboIdJefe();
        }

        private void ModificarEmpleado_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();

            emp.Id = int.Parse(txtId.Text);
            emp.NumDoc = txtNumDoc.Text;
            emp.TipoDoc = (cmbTipoDoc.SelectedValue).ToString();
            emp.Nombre = txtNombre.Text;
            emp.Apellido = txtApellido.Text;
            emp.Direccion = txtDireccion.Text;
            emp.IdBarrio = (int)cmbBarrio.SelectedValue;
            emp.Telefono = txtTelefono.Text;
            emp.JefeId = (int)cmbIdJefe.SelectedValue;
            emp.Activo = true;

            string msg_confirmacion = "¿Está seguro que desea realizar las modificaciones?";
            DialogResult dialogResult = MessageBox.Show(msg_confirmacion, "Confirmacion", MessageBoxButtons.YesNo);



            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    bool resultado = EmpleadoDAO.ActualizarEmpleado(emp, emp.Id);
                    if (resultado)
                    {
                        MessageBox.Show("Empleado modificado con éxito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se ha modificado el empleado");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al modificar empleado");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
