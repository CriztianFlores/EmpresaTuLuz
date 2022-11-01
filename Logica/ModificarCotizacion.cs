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
    public partial class ModificarCotizacion : Form
    {
        public ModificarCotizacion(int idCotizacion)
        {
            InitializeComponent();
            CargarInfoCotizacion(idCotizacion);
            CargarDetalleCotizacion(idCotizacion);

        }


        private void AltaCotizaciones_Load(object sender, EventArgs e)
        {
            ObtenerUltimoNroCotizacion();
    
            //CargarCombos();
        }
        private void CargarInfoCotizacion(int idCotizacion)
        {
            DataTable tabla = CotizacionDAO.ObtenerCotizacionXId(idCotizacion);
            lblVendedorApellido.Text = tabla.Rows[0]["empleado_apellido"].ToString();
            lblVendedorNombre.Text = tabla.Rows[0]["empleado_nombre"].ToString();
            lblVendedorDni.Text = tabla.Rows[0]["empleado_num_doc"].ToString();
            lblClienteApellido.Text = tabla.Rows[0]["cliente_apellido"].ToString();
            lblClienteNombre.Text = tabla.Rows[0]["cliente_nombre"].ToString();
            lblClienteCuit.Text = tabla.Rows[0]["cliente_cuit"].ToString();
            txtNroCotizacion.Text = tabla.Rows[0]["numCotizacion"].ToString();
            txtfecha.Text = tabla.Rows[0]["fecha"].ToString();
            txtTotal.Text = tabla.Rows[0]["precioTotal"].ToString();
            txtObservaciones.Text = tabla.Rows[0]["observaciones"].ToString();
            txtMotivoPerdida.Text = tabla.Rows[0]["motivo_perdida"].ToString();
            txtMotivoPerdida.Enabled = false;
            if (tabla.Rows[0]["estado"].ToString() == "Aprobada" || tabla.Rows[0]["estado"].ToString() == "Perdida") {
                cmbEstado.Enabled = false;
                cmbEstado.Text = tabla.Rows[0]["estado"].ToString();
                txtMotivoPerdida.Enabled = false;
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
            DialogResult dialogResult = MessageBox.Show("Desea realmente modificar la cotizacion?", "Confirmacion", MessageBoxButtons.YesNo);
            bool camposCorrectos = txtMotivoPerdida.TextLength < 11 && txtObservaciones.TextLength < 201;
            if (!camposCorrectos)
            {
                if(txtMotivoPerdida.TextLength > 10)
                MessageBox.Show("El motivo de perdida debe tener un maximo de 10 caracteres");
                else
                {
                    MessageBox.Show("Las observaciones de perdida debe tener un maximo de 200 caracteres");
                }
            }
            string motivoPerdida = "";
            string state = "-1";
            if (dialogResult == DialogResult.Yes && camposCorrectos)
            {
                if (cmbEstado.SelectedItem != null) { 
                    switch (cmbEstado.SelectedItem.ToString())
                    {
                        case "Aprobada":
                            motivoPerdida = "";
                            state = "3";
                            break;
                        case "Perdida":
                            motivoPerdida = txtMotivoPerdida.Text;
                            state = "4";
                            break;
                        default:
                            motivoPerdida = "";
                            state = "-1";
                            break;
                    }
                }       
                        try
                        {
                            bool resultado = CotizacionDAO.actualizarCotizacion(txtObservaciones.Text, state, motivoPerdida, int.Parse(txtNroCotizacion.Text));

                        if (resultado)
                            {
                                MessageBox.Show("Cotizacion modificada con exito");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error al modificar la cotizacion");
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error al modificar la cotizacion");
                        
                        }   

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
           if(cmbEstado.SelectedItem == "Perdida")
            {
                txtMotivoPerdida.Enabled = true;
            }
            else{
                txtMotivoPerdida.Enabled = false;

            }
        }
    }
}
