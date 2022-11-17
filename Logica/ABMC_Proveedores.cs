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
    public partial class ABMC_Proveedores : Form
    {
        public ABMC_Proveedores()
        {
            InitializeComponent();
        }

        private void ABMC_Proveedores_Load(object sender, EventArgs e)
        {
            CargarComboProveedores();
            LimpiarCampos();
            CargarGrilla();
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        private void LimpiarCampos()
        {
            txtRazonSocial.Text = "";
            txtMail.Text = "";
            txtTelefono.Text = "";
            txtId.Text = "";
            txtEstado.Text = "";
        }
        private void CargarGrilla()
        {
            grillaProveedores.DataSource = ProveedorDAO.ObtenerTablaProveedores();
        }

        private void grillaProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice > -1)
            {
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                DataGridViewRow filaSeleccionada = grillaProveedores.Rows[indice];
                int proveedorId = int.Parse(filaSeleccionada.Cells["proveedor_id"].Value.ToString());
                Proveedor p = ProveedorDAO.ObtenerProveedorById(proveedorId);
                CargarCampos(p);
            }
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
        private void CargarComboProveedores()
        {

            DataTable tabla = ProveedorDAO.ObtenerTablaProveedores();



            cmbBuscarProveedor.DataSource = tabla;
            cmbBuscarProveedor.DisplayMember = "razon_social";
            cmbBuscarProveedor.ValueMember = "proveedor_id";
            cmbBuscarProveedor.SelectedIndex = -1;



        }
        private void rbtn_todos_CheckedChanged(object sender, EventArgs e)
        {
            grillaProveedores.DataSource = ProveedorDAO.ObtenerTablaProveedores();
        }

        private void rbtn_inactivos_CheckedChanged(object sender, EventArgs e)
        {
            grillaProveedores.DataSource = ProveedorDAO.ObtenerListadoProveedoresInactivos();
        }

        private void rbtn_todos_CheckedChanged_1(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void rbtn_activos_CheckedChanged(object sender, EventArgs e)
        {
            grillaProveedores.DataSource = ProveedorDAO.ObtenerListadoProveedoresActivos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int proveedor_id = -3;
            if (cmbBuscarProveedor.SelectedIndex != -1)
            {
                proveedor_id = (int)cmbBuscarProveedor.SelectedValue;

                grillaProveedores.DataSource = ProveedorDAO.ObtenerTablaProveedoresById(proveedor_id);

            }
            else
            {
                MessageBox.Show("Seleccione un proveedor");
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Proveedores ventana = new Proveedores();
            ventana.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = grillaProveedores.Rows[grillaProveedores.CurrentCell.RowIndex];
            int idProv = int.Parse(filaSeleccionada.Cells["proveedor_id"].Value.ToString());
            //Proveedor p = ProveedorDAO.ObtenerProveedorById(idProv);

            ModificarProveedor ventana = new ModificarProveedor(idProv);
            ventana.ShowDialog();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int posicionSeleccionada = grillaProveedores.CurrentRow.Index;
            DataGridViewRow filaSeleccionada = grillaProveedores.Rows[posicionSeleccionada];
            int index = int.Parse(filaSeleccionada.Cells["proveedor_id"].Value.ToString());
            string msg_confirmacion = "";
            int value;
            string msgExito;
            if ((filaSeleccionada.Cells["proveedor_activo"].Value.ToString() == "1"))
            {
                msg_confirmacion = "Seguro que desea eliminar el proveedor: \n\n Razon social: " + filaSeleccionada.Cells["razon_social"].Value.ToString() +
                   "\n\n ID: " + filaSeleccionada.Cells["proveedor_id"].Value.ToString();
                value = 0;
                msgExito = "Proveedor eliminado con exito";
                DialogResult dialogResult = MessageBox.Show(msg_confirmacion, "Confirmacion", MessageBoxButtons.YesNo);


                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {

                        bool resultado = ProveedorDAO.EliminarProveedor(index, value);
                        if (resultado)
                        {
                            MessageBox.Show(msgExito);

                            CargarGrilla();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar proveedor");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al eliminar proveedor");
                    }
                }
            }
            else
            {
                value = 0;
                MessageBox.Show("El proveedor se encuentra inactivo");
                //msg_confirmacion = "El usuario seleccionado ya está inactivo";
                //msgExito = "";
                /*msg_confirmacion = "Seguro que desea habilitar el usuario el usuario: \n\n Nombre: " + filaSeleccionada.Cells["usuario_nombre"].Value.ToString() +
                 "\n\n ID: " + filaSeleccionada.Cells["usuario_id"].Value.ToString() + " \n\n Si se habilita el usuario podra acceder nuevamente al sistema.";
                value = 1;
                msgExito = "Usuario habilitado con exito";*/

            }


        }
        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            CargarGrilla();
            CargarComboProveedores();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }

}
