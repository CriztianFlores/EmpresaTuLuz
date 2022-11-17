using EmpresaTuLuz.DAO;
using EmpresaTuLuz.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaTuLuz.Logica
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }
        private void Proveedores_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            LimpiarCampos();
        }
        private void CargarGrilla()
        {
            grillaProveedores.DataSource = ProveedorDAO.ObtenerListadoProveedoresActivos();
        }
        private void LimpiarCampos()
        {
            txtRazonSocial.Text = "";
            txtMail.Text = "";
            txtTelefono.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Proveedor p = new Proveedor();

            p.RazonSocial = txtRazonSocial.Text;
            p.Mail = txtMail.Text;
            p.Telefono = txtTelefono.Text;
            p.Activo = true;

            ProveedorDAO.RegistrarProveedor(p);
            CargarGrilla();
            LimpiarCampos();
        }
    }
}
