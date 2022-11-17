using EmpresaTuLuz.DAO;
using EmpresaTuLuz.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaTuLuz.Logica
{
    public partial class AltaVenta : Form
    {
        public AltaVenta(int idCotizacion)
        {
            InitializeComponent();
            CargarInfoCotizacion(idCotizacion);
            CargarDetalleCotizacion(idCotizacion);
            CargarComboVendedor();
            CargarComboMediosPagos();

        }


        private void AltaCotizaciones_Load(object sender, EventArgs e)
        {
            ObtenerUltimoNroCotizacion();

            //CargarCombos();
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

                cbFormaDePago.DataSource = tabla;
                cbFormaDePago.DisplayMember = "FORMA_DE_PAGO_NOMBRE";
                cbFormaDePago.ValueMember = "FORMA_DE_PAGO_ID";
                cbFormaDePago.SelectedIndex = 0;

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
        private void CargarInfoCotizacion(int idCotizacion)
        {
            DataTable tabla = CotizacionDAO.ObtenerCotizacionXId(idCotizacion);
            lblClienteApellido.Text = tabla.Rows[0]["cliente_apellido"].ToString();
            lblClienteNombre.Text = tabla.Rows[0]["cliente_nombre"].ToString();
            lblClienteCuit.Text = tabla.Rows[0]["cliente_cuit"].ToString();
            txtNroCotizacion.Text = tabla.Rows[0]["numCotizacion"].ToString();
            txtfecha.Text = DateTime.Now.ToShortDateString();
            txtTotal.Text = tabla.Rows[0]["precioTotal"].ToString();
            txtObservaciones.Text = tabla.Rows[0]["observaciones"].ToString();

            if (tabla.Rows[0]["estado"].ToString() == "Aprobada" || tabla.Rows[0]["estado"].ToString() == "Perdida")
            {

            }

        }
        private void CargarComboVendedor()
        {
            cmbVendedor.SelectedIndexChanged -= new EventHandler(cmbVendedor_SelectedIndexChanged);
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

                cmbVendedor.DataSource = tabla;
                cmbVendedor.DisplayMember = "empleado_apellido";
                cmbVendedor.ValueMember = "empleado_id";
                cmbVendedor.SelectedIndex = -1;
                cmbVendedor.SelectedIndexChanged += new EventHandler(cmbVendedor_SelectedIndexChanged);


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
        private void CargarDetalleCotizacion(int idCotizacion)
        {
            DataTable tabla = CotizacionDAO.ObtenerDetallesCotizacion(idCotizacion);
            grillaProductos.DataSource = tabla;

        }

        private void ObtenerUltimoNroCotizacion()
        {

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }



        private void cmbIdCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarCotizacion_Click(object sender, EventArgs e)
        {
            if ( cmbVendedor.Text != "" && cmbVendedor.SelectedValue != null)
            {
                bool resultado = VentaDAO.AltaVenta(int.Parse(txtNroCotizacion.Text), int.Parse(cmbVendedor.SelectedValue.ToString()), int.Parse(cbFormaDePago.SelectedValue.ToString()));

                if (resultado)
                {
                    MessageBox.Show("Venta registrada con exito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al registrar la venta");
                }
            }
            else
            {
          
             
                    MessageBox.Show("Seleccione un vendedor");
                
          
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
      
        }

        private void cmbVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbVendedor_SelectionChangeCommitted(sender, e);

        }
        private void cmbVendedor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                DataRowView itemSeleccionado = (DataRowView)cmbVendedor.SelectedItem;
                String text = itemSeleccionado["empleado_id"].ToString();
                Empleado vendedor = EmpleadoDAO.obtenerEmpleadoById(int.Parse(text));
                if (vendedor.NumDoc != null)
                {
                    lblVendedorNombre.Text = vendedor.Nombre;
                    lblVendedorDni.Text = vendedor.NumDoc;

                }
                else
                {
                    MessageBox.Show("Cliente Inexistente");
                }

            }

            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
