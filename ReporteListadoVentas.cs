using EmpresaTuLuz.DAO;
using EmpresaTuLuz.Entidades;
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
    public partial class ReporteListadoVentas : Form
    {
        public ReporteListadoVentas()
        {
            InitializeComponent();
        }

        private void ReporteListadoVentas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PROYECTODataSet.VENTAS' table. You can move, or remove it, as needed.
            //this.VENTASTableAdapter.Fill(this.PROYECTODataSet.VENTAS);
            CargarComboVendedor();
            CargarComboMediosPagos();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = VentasDAO.obtenerListadoDeVentas();
            fillTable(tabla);
            this.reportViewer1.RefreshReport();


        }

        private void cbModoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chbFecha_CheckedChanged(object sender, EventArgs e)
        {
            fechaDesde.Enabled = chbFecha.Checked;
            fechaHasta.Enabled = chbFecha.Checked;
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
                cmbVendedor.SelectedIndex = cmbVendedor.Items.Count-1;


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
                cbFormaDePago.SelectedIndex = cbFormaDePago.Items.Count - 1; ;

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
            DataTable tabla = new DataTable();
            tabla = VentasDAO.obtenerListadoDeVentas();
            fillTable(tabla);
            this.reportViewer1.RefreshReport();
        }
        private void fillTable(DataTable tabla)
        {
            DataTable tablaFiltrada = filtrarTabla(tabla);
            DataTable dtCloned = tablaFiltrada.Clone();
            dtCloned.Columns[1].DataType = typeof(String);
            foreach (DataRow row in tablaFiltrada.Rows)
            {
                dtCloned.ImportRow(row);
            }
            foreach (DataRow dr in dtCloned.Rows)
            {
                String value = DateTime.Parse(dr["venta_fecha"].ToString()).ToString("dd/MM/yy");
                dr["venta_fecha"] = value;
               // dr["precioTotal"] = Math.Round(double.Parse(dr["precioTotal"].ToString()), 2);
            }
            ReportDataSource ds = new ReportDataSource("DatosVendidos", dtCloned);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
        public DataTable filtrarTabla(DataTable tabla)
        {
            string periodoFiltro = chbFecha.Checked ? "venta_fecha >= '" + fechaDesde.Value + "' and venta_fecha <='" + fechaHasta.Value + "' " : "";
            string formaDePagoFiltro = cbFormaDePago.Text == "Todos" ? "": "forma_de_pago_id = '" + cbFormaDePago.Text +"'";
            string vendedorFiltro = cmbVendedor.Text == "Todos" ? "" : " empleado_id = '" + cmbVendedor.Text + "'";
            string conector = periodoFiltro != "" && formaDePagoFiltro != "" ? " AND " : "";
            string conectorEstado = (periodoFiltro != "" || formaDePagoFiltro != "") && vendedorFiltro != "" ? " AND " : "";
            DataTable _newDataTable;
            if (periodoFiltro != "" || formaDePagoFiltro != "" || vendedorFiltro != "")
            {

                DataRow[] value = tabla.Select(periodoFiltro + conector + formaDePagoFiltro + conectorEstado + vendedorFiltro);
                if (value.Length > 0)
                {
                    _newDataTable = value.CopyToDataTable();

                }
                else
                {
                    tabla.Clear();
                    _newDataTable = tabla.Clone();
                }

            }
            else
            {
                _newDataTable = tabla;
            }
            return _newDataTable;



        }
    }
}
