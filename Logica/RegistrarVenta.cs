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


namespace EmpresaTuLuz.Logica
{
    public partial class RegistrarVenta : Form
    {
        private DataTable tablaCotizaciones;
        public RegistrarVenta()
        {
            InitializeComponent();
        }

        private void ABMC_Cotizaciones_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        public void CargarGrilla()
        {
            //Crear objeto conexion
            tablaCotizaciones = CotizacionDAO.ObtenerCotizaciones();
            grillaCotizaciones.DataSource = tablaCotizaciones;
            filtrarGrilla();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            DataGridViewRow filaSeleccionada = grillaCotizaciones.Rows[grillaCotizaciones.CurrentCell.RowIndex];
            int cotizacion = int.Parse(filaSeleccionada.Cells["numCotizacion"].Value.ToString());
            AltaVenta ventana = new AltaVenta(cotizacion);
            ventana.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            ventana.Show();
        }
        public void filtrarGrilla()
        {
            string vendedorFiltro = txtVendedor.Text == "" ? "" : "empleado_apellido LIKE '%" + txtVendedor.Text + "%'";
            string clienteFiltro = txtCliente.Text == "" ? "" : "apellidoCliente LIKE '%" + txtCliente.Text + "%'";
            string estadoFiltro ="estado = 'Aprobada'";
            string conector = vendedorFiltro != "" && clienteFiltro != "" ? "AND " : "";
            string conectorEstado = (vendedorFiltro != "" || clienteFiltro != "") && estadoFiltro != "" ? " AND " : "";
            BindingSource bs = new BindingSource();
            bs.DataSource = grillaCotizaciones.DataSource;
            bs.Filter = vendedorFiltro + conector + clienteFiltro + conectorEstado + estadoFiltro;
            grillaCotizaciones.DataSource = bs;



        }
        void actualizarGrilla(object sender, FormClosedEventArgs e)
        {
            CargarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = grillaCotizaciones.Rows[grillaCotizaciones.CurrentCell.RowIndex];
            int cotizacion = int.Parse(filaSeleccionada.Cells["numCotizacion"].Value.ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            ABMC_Cotizaciones ventanaCotizaciones = new ABMC_Cotizaciones();
            ventanaCotizaciones.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            ventanaCotizaciones.ShowDialog();
               
        }
    }
}
