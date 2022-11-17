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
    public partial class ReporteListadoCotizaciones : Form
    {
        public ReporteListadoCotizaciones()
        {
            InitializeComponent();
        }

        private void ReporteListadoCotizaciones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PROYECTODataSet.COTIZACIONES' table. You can move, or remove it, as needed.
            //this.COTIZACIONESTableAdapter.Fill(this.PROYECTODataSet.COTIZACIONES);

            this.rvCotizaciones.RefreshReport();
            CargarCombo();
        }

        private void rvCotizaciones_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = CotizacionDAO.ObtenerCotizaciones();
            fillTable(tabla);


        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable tabla = new DataTable();
            tabla = CotizacionDAO.ObtenerCotizaciones();
            fillTable(tabla);
            this.rvCotizaciones.RefreshReport();
        }
        private void fillTable(DataTable tabla)
        {
            DataTable tablaFiltrada = filtrarTabla(tabla);
            DataTable dtCloned = tablaFiltrada.Clone();
            dtCloned.Columns[6].DataType = typeof(String);
            foreach (DataRow row in tablaFiltrada.Rows)
            {
                dtCloned.ImportRow(row);
            }
            foreach (DataRow dr in dtCloned.Rows)
            {
                String value = DateTime.Parse(dr["fecha"].ToString()).ToString("dd/MM/yy");
                dr["fecha"] = value;
                dr["precioTotal"] = Math.Round(double.Parse(dr["precioTotal"].ToString()),2);
            }
            ReportDataSource ds = new ReportDataSource("cotizacionesDetalladas", dtCloned);

            rvCotizaciones.LocalReport.DataSources.Clear();
            rvCotizaciones.LocalReport.DataSources.Add(ds);
            rvCotizaciones.LocalReport.Refresh();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public DataTable filtrarTabla(DataTable tabla)
        {
            string precioFiltro = chbPrecio.Checked ?  "precioTotal >= "+ precioMinimo.Value + " and precioTotal <= " + precioMaximo.Value + " " : "";
            string periodoFiltro = chbPeriodo.Checked ? "fecha >= '" + fechaDesde.Value + "' and fecha <='" + fechaHasta.Value +"' ": "";
            string estadoFiltro = cmbEstados.Text == "Todos" ? "" : "estado = '" + cmbEstados.Text + "'";
            string conector = periodoFiltro != "" && precioFiltro != "" ? " AND " : "";
            string conectorEstado = (periodoFiltro != "" || precioFiltro != "") && estadoFiltro != "" ? " AND " : "";
            DataTable _newDataTable;
            if (periodoFiltro != "" || precioFiltro != "" || estadoFiltro !="") {
              
                DataRow[] value = tabla.Select(periodoFiltro + conector + precioFiltro + conectorEstado + estadoFiltro);
                if (value.Length > 0) {
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
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chbPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            fechaDesde.Enabled = chbPeriodo.Checked;
            fechaHasta.Enabled = chbPeriodo.Checked;
        }

        private void chbPrecio_CheckedChanged(object sender, EventArgs e)
        {
            precioMaximo.Enabled = chbPrecio.Checked;
            precioMinimo.Enabled = chbPrecio.Checked;
        }
    }
}
