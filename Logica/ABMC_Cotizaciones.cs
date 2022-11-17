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
using EmpresaTuLuz.DAO;
using EmpresaTuLuz.Entidades;


namespace EmpresaTuLuz.Logica
{
    public partial class ABMC_Cotizaciones : Form
    {
        private DataTable tablaCotizaciones;
        public ABMC_Cotizaciones()
        {
            InitializeComponent();
        }

        private void ABMC_Cotizaciones_Load(object sender, EventArgs e)
        {
            CargarCombo();
            CargarGrilla();
        }
        private void CargarCombo()
        {
           
                //Crear objeto conexion
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlConnection cn = new SqlConnection(cadenaConexion);
                try
                {
                    //Crear objeto sql command
                    SqlCommand cmd = new SqlCommand();

                    //Escribir consulta SQL
                    string consulta = "SELECT * FROM estados_cotizaciones";
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;

                    DataTable tabla = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    DataRow todosRow = tabla.NewRow();
                    todosRow["descripcion"] = "Todos";
                    tabla.Rows.Add(todosRow);
                    cmbEstados.DataSource = tabla;
                    cmbEstados.DisplayMember = "descripcion";
                    cmbEstados.ValueMember = "id_estado";
                    cmbEstados.SelectedIndex = 4;

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
        public void CargarGrilla()
        {
            //Crear objeto conexion
            tablaCotizaciones = CotizacionDAO.ObtenerCotizaciones();
            grillaCotizaciones.DataSource = tablaCotizaciones;
       

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaCotizaciones ventana = new AltaCotizaciones();
            ventana.FormClosed += new FormClosedEventHandler(actualizarGrilla);

            ventana.ShowDialog();
        }
        public void filtrarGrilla()
        {
            string vendedorFiltro = txtVendedor.Text == "" ? "" : "empleado_apellido LIKE '%" + txtVendedor.Text + "%'";
            string clienteFiltro = txtCliente.Text == "" ? "" : "apellidoCliente LIKE '%" + txtCliente.Text + "%'";
            string estadoFiltro = cmbEstados.Text == "Todos" ? "" :"estado = '" + cmbEstados.Text+"'";
            string conector = vendedorFiltro != "" && clienteFiltro != ""? "AND " : "";
            string conectorEstado = (vendedorFiltro != "" || clienteFiltro != "") && estadoFiltro != "" ? " AND " : "";
            BindingSource bs = new BindingSource();
            bs.DataSource = grillaCotizaciones.DataSource;
            bs.Filter =  vendedorFiltro + conector + clienteFiltro + conectorEstado + estadoFiltro ;
            grillaCotizaciones.DataSource = bs;

         

        }
        void actualizarGrilla(object sender, FormClosedEventArgs e)
        {
            CargarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = grillaCotizaciones.Rows[grillaCotizaciones.CurrentCell.RowIndex];
            int cotizacion =int.Parse(filaSeleccionada.Cells["numCotizacion"].Value.ToString());
            ModificarCotizacion modificarCotizacion = new ModificarCotizacion(cotizacion);
            modificarCotizacion.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            modificarCotizacion.Show();
        }
        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarGrilla();

        }
        private void btnBuscarTodo_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtrarGrilla();
        }

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }
    }
}
