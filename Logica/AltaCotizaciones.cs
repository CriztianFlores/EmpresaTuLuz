using System;
using EmpresaTuLuz.DAO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EmpresaTuLuz.Entidades;

namespace EmpresaTuLuz.Logica
{
    public partial class AltaCotizaciones : Form
    {
        public AltaCotizaciones()
        {
            InitializeComponent();
        }


        private void AltaCotizaciones_Load(object sender, EventArgs e)
        {
            Cargafecha();
            ObtenerUltimoNroCotizacion();
            CargarComboCliente();
            CargarComboEstado();
            CargarComboVendedor();
            CargarComboProducto();
            //CargarCombos();
        }
        private void Cargafecha()
            {
                txtfecha.Text=DateTime.Now.ToShortDateString();
                

            }
        /*public void CargarCombos()
        {
            CargarComboCliente();
            CargarComboEstado();
            CargarComboVendedor();
            CargarComboProducto();
        }*/

        private void ObtenerUltimoNroCotizacion()
        {
            int id = CotizacionDAO.ObtenerUltimoNroCotizacion();
            txtNroCotizacion.Text = (id + 1).ToString();
        }
        private void CargarComboCliente()
        {

            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                cmbIdCliente.SelectedIndexChanged -= new EventHandler(cmbIdCliente_SelectedIndexChanged);

                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM clientes";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbIdCliente.DataSource = tabla;
                cmbIdCliente.DisplayMember = "cliente_apellido";
                cmbIdCliente.ValueMember = "cliente_id";
                cmbIdCliente.SelectedIndex = -1;
                cmbIdCliente.SelectedIndexChanged += new EventHandler(cmbIdCliente_SelectedIndexChanged);


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
        private void CargarComboEstado()
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

                cmbEstado.DataSource = tabla;
                cmbEstado.DisplayMember = "descripcion";
                cmbEstado.ValueMember = "id_estado";
                cmbEstado.SelectedIndex = 1;

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

        private void CargarComboProducto()
        {

            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                cmbProducto.SelectedIndexChanged -= new EventHandler(cmbProducto_SelectedIndexChanged);

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

                cmbProducto.DataSource = tabla;
                cmbProducto.DisplayMember = "nombre";
                cmbProducto.ValueMember = "id";
                cmbProducto.SelectedIndex = -1;
                cmbProducto.SelectedIndexChanged += new EventHandler(cmbProducto_SelectedIndexChanged);


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
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
    
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            DataTable tablaResultado = ProductoDAO.Obtenerproductoxnombre(cmbProducto.Text);
            float PxC= 0;

            if (tablaResultado.Rows.Count > 0)
            {
                float precioUni = float.Parse(tablaResultado.Rows[0][2].ToString());
                if (txtCantidad.Text != "")
                {
                    float cantP = float.Parse(txtCantidad.Text);
                    PxC = precioUni * cantP;
                    grillaProductos.Rows.Add(cmbProducto.SelectedValue, cmbProducto.Text, txtCantidad.Text, precioUni, PxC);
                }
                else
                 {
              
                MessageBox.Show("Ingrese una cantidad");
                    
                }
            }
            
        }

        

        private void cmbProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                //string text =cmbProducto.SelectedValue.ToString();

                DataRowView itemSeleccionado = (DataRowView)cmbProducto.SelectedItem;
                String text = itemSeleccionado["nombre"].ToString();
                DataTable tablaResultado = ProductoDAO.Obtenerproductoxnombre(text);
                if (tablaResultado.Rows.Count > 0)
                {
                    lblProductoPrecio.Text = tablaResultado.Rows[0][2].ToString();



                }
                else
                {
                    MessageBox.Show("Producto Inexistente");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
          

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow Fila in grillaProductos.Rows)
            {
                double subtotal = Convert.ToDouble(Fila.Cells[3].Value);
                total += subtotal;
            }
            txtTotal.Text = total.ToString();
        }
        private void btnGuardarCotizacion_Click(object sender, EventArgs e)
        {
            List<int[]> listaProductos = new List<int[]>();
            for (int i = 0; i < grillaProductos.Rows.Count; i++)
            {
                string valor = grillaProductos.Rows[i].Cells[0].Value.ToString();
                string otroValor = grillaProductos.Rows[i].Cells[1].Value.ToString();
                int[] ítem = { int.Parse(grillaProductos.Rows[i].Cells[0].Value.ToString()), int.Parse(grillaProductos.Rows[i].Cells[2].Value.ToString()) };
                listaProductos.Add(ítem);
            }

     
            if (listaProductos.Count > 0 && cmbIdCliente.Text != "" && cmbVendedor.Text != "" && cmbEstado.Text != "") { 
                bool resultado = CotizacionDAO.AltaCotizacion(int.Parse(txtNroCotizacion.Text), int.Parse(cmbIdCliente.SelectedValue.ToString()), int.Parse(cmbVendedor.SelectedValue.ToString()), int.Parse(cmbEstado.SelectedValue.ToString()), lblClienteNombre.Text, cmbIdCliente.Text, txtObservaciones.Text, float.Parse(txtTotal.Text), "", listaProductos);
                if (resultado) 
                {
                    MessageBox.Show("Alta de detalle de cotizacion exitoso");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al dar alta detalle de cotizacion");
                }
            }
            else 
            {
                if (listaProductos.Count == 0) {
                MessageBox.Show("Debe cargar al menos un producto");
                }
                if (cmbIdCliente.Text == "")
                {
                    MessageBox.Show("Seleccione un cliente");
                }
                if (cmbVendedor.Text == "")
                {
                    MessageBox.Show("Seleccione un vendedor");
                }
                if (cmbEstado.Text == "")
                {
                    MessageBox.Show("Seleccione un estado");
                }
            }
        }


        private void grillaProductos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow Fila in grillaProductos.Rows)
            {
                double subtotal = Convert.ToDouble(Fila.Cells[3].Value);
                total += subtotal;
            }
            txtTotal.Text = total.ToString();
        }

        private void grillaProductos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow Fila in grillaProductos.Rows)
            {
                double subtotal = Convert.ToDouble(Fila.Cells[3].Value);
                total += subtotal;
            }
            txtTotal.Text = total.ToString();
        }

        private void cmbIdCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIdCliente_SelectionChangeCommitted(sender, e);
        }

        private void cmbIdCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                DataRowView itemSeleccionado = (DataRowView)cmbIdCliente.SelectedItem;
                String text = itemSeleccionado["cliente_id"].ToString();
                DataTable tablaResultado = ClienteDAO.ObtenerClientexId(int.Parse(text));
                if (tablaResultado.Rows.Count > 0)
                {
                    lblClienteNombre.Text = tablaResultado.Rows[0][2].ToString();
                    lblClienteCuit.Text = tablaResultado.Rows[0][1].ToString();

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

        private void cmbVendedor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                DataRowView itemSeleccionado = (DataRowView)cmbVendedor.SelectedItem;
                String text = itemSeleccionado["empleado_id"].ToString();
                Empleado vendedor = EmpleadoDAO.obtenerEmpleadoById(int.Parse(text));
                if (vendedor.NumDoc != null )
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

        private void cmbVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
         
                cmbVendedor_SelectionChangeCommitted(sender,  e);
            
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProducto_SelectionChangeCommitted(sender, e);
        }
    }
}
