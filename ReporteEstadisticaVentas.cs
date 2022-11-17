using EmpresaTuLuz.DAO;
using Microsoft.Reporting.WinForms;
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
    public partial class ReporteEstadisticaVentas : Form
    {
        public ReporteEstadisticaVentas()
        {
            InitializeComponent();
            CargarComboVendedor();
            CargarComboProducto();
            CargarComboMediosPagos();
        }

        private void ReporteEstadisticaVentas_Load(object sender, EventArgs e)
        {

            this.rvEstadisticaVentaProducto.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {         
            fillTable();  
        }
        public DataTable filtrarTabla()
        {
            DataTable tabla = new DataTable();
            int vendedorId = cmbVendedor.Text == "Todos" ? -1 : int.Parse(cmbVendedor.SelectedValue.ToString());
            int productoId = cbProducto.Text == "Todos" ? -1 : int.Parse(cbProducto.SelectedValue.ToString());
            int modoId = cbFormaDePago.Text == "Todos" ? -1 : int.Parse(cbFormaDePago.SelectedValue.ToString());
            int año = int.Parse(cbAño.Text);
            tabla = VentasDAO.obtenerEstadisticaDeVentaEmpleado(vendedorId, productoId,2022, modoId);
           return tabla;

        }
        private void fillTable()
        {
            DataTable tablaFiltrada = filtrarTabla();
            ReportDataSource ds = new ReportDataSource("DatosEstadisticasProductos", tablaFiltrada);

            rvEstadisticaVentaProducto.LocalReport.DataSources.Clear();
            rvEstadisticaVentaProducto.LocalReport.DataSources.Add(ds);
            rvEstadisticaVentaProducto.LocalReport.Refresh();
        }
        private void CargarComboVendedor()
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

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                DataRow todosRow = tabla.NewRow();
                todosRow["empleado_apellido"] = "Todos";
                todosRow["empleado_id"] = "-1";
                tabla.Rows.Add(todosRow);
                cmbVendedor.DataSource = tabla;
                cmbVendedor.DisplayMember = "empleado_apellido";
                cmbVendedor.ValueMember = "empleado_id";
                cmbVendedor.SelectedIndex = cmbVendedor.Items.Count - 1;


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
        private void CargarComboMediosPagos()
        {

            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM FORMAS_DE_PAGO";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                DataRow todosRow = tabla.NewRow();
                todosRow["FORMA_DE_PAGO_NOMBRE"] = "Todos";
                todosRow["FORMA_DE_PAGO_ID"] = "-1";
                tabla.Rows.Add(todosRow);
                cbFormaDePago.DataSource = tabla;
                cbFormaDePago.DisplayMember = "FORMA_DE_PAGO_NOMBRE";
                cbFormaDePago.ValueMember = "FORMA_DE_PAGO_ID";
                cbFormaDePago.SelectedIndex = cbFormaDePago.Items.Count - 1;
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
        private void CargarComboProducto()
        {

            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM productos";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                DataRow todosRow = tabla.NewRow();
                todosRow["nombre"] = "Todos";
                todosRow["id"] = "-1";
                tabla.Rows.Add(todosRow);
                cbProducto.DataSource = tabla;
                cbProducto.DisplayMember = "nombre";
                cbProducto.ValueMember = "id";
                cbProducto.SelectedIndex = cbProducto.Items.Count - 1;


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
            fillTable();
            this.rvEstadisticaVentaProducto.RefreshReport();

        }
    }
}
