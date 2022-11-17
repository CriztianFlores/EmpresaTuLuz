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
    public partial class ModificarProveedor : Form
    {
        int idProv;
        public ModificarProveedor()
        {
            InitializeComponent();
        }
        public ModificarProveedor(int id)
        {

            idProv = id;
            Proveedor p = ProveedorDAO.ObtenerProveedorById(idProv);
            bool isNewUser = p.RazonSocial == null;
            InitializeComponent();
            if (!isNewUser)
            {
                CargarCampos(p);

            }

        }
        private void ModificarProveedor_Load(object sender, EventArgs e)
        {

        }

        private void CargarCampos(Proveedor p)
        {
            txtRazonSocial.Text = p.RazonSocial;
            txtMail.Text = p.Mail;
            txtTelefono.Text = p.Telefono;
            txtId.Text = (p.Id).ToString();
            txtEstado.Text = EstadoProveedor(p.Activo);

        }
        private string EstadoProveedor(bool estado)
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

        private void btnModificar_Click(object sender, EventArgs e)
        {

            Proveedor p = new Proveedor();

            p.Id = int.Parse(txtId.Text);
            p.RazonSocial = txtRazonSocial.Text;
            p.Mail = txtMail.Text;
            p.Telefono = txtTelefono.Text;
            p.Activo = true;

            string msg_confirmacion = "¿Está seguro que desea realizar las modificaciones?";
            DialogResult dialogResult = MessageBox.Show(msg_confirmacion, "Confirmacion", MessageBoxButtons.YesNo);



            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    bool resultado = ProveedorDAO.ActualizarProveedor(p, p.Id);
                    if (resultado)
                    {
                        MessageBox.Show("Proveedor modificado con éxito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se ha modificado el Proveedor");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al modificar Proveedor");
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
