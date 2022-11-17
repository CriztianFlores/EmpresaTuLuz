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
    public partial class ABMC_Empleados : Form
    {
        public ABMC_Empleados()
        {
            InitializeComponent();
        }
        private void ABMC_Empleados_Load(object sender, EventArgs e)
        {
            CargarComboEmpleado();
            LimpiarCampos();
            CargarGrilla();
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;

        }
        /*private void CargarGrillaxEstado()
        {
            int estado;
            if (rbtn_activos.Checked)
            {
                estado = 1;
            }
            else if (rbtn_inactivos.Checked)
            {
                estado = 0;
            }
            else
            {
                estado = 2;
            }
            grillaEmpleados.DataSource = EmpleadoDAO.obtenerListadoEmpleadosXEstado(estado);
        }*/
        private void CargarGrilla()
        {
            grillaEmpleados.DataSource = EmpleadoDAO.obtenerTablaEmpleados();
        }
        private void LimpiarCampos()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDocumento.Text = "";
            txtTipoDoc.Text = "";
            txtDireccion.Text = "";
            txtBarrio.Text = "";
            txtTelefono.Text = "";
            txtId.Text = "";
            txtEstado.Text = "";
            txtIdJefe.Text = "";

        }



        private void grillaEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice > -1)
            {
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                DataGridViewRow filaSeleccionada = grillaEmpleados.Rows[indice];
                int empleadoId = int.Parse(filaSeleccionada.Cells["empleado_id"].Value.ToString());
                Empleado u = EmpleadoDAO.obtenerEmpleadoById(empleadoId);
                cargarCampos(u);
            }
        }
        private void cargarCampos(Empleado e)
        {

            //Empleado e = EmpleadoDAO.obtenerEmpleadoById((u.id);

            txtNombre.Text = e.Nombre;
            txtApellido.Text = e.Apellido;
            txtTipoDoc.Text = (e.TipoDoc == "1") ? "DNI" : "Pasaporte";
            txtDocumento.Text = e.NumDoc;
            txtDireccion.Text = e.Direccion;
            txtBarrio.Text = ObtenerBarrio(e.IdBarrio);
            txtTelefono.Text = e.Telefono;
            txtId.Text = e.Id.ToString();
            txtEstado.Text = EstadoEmpleado(e.Activo);
            txtIdJefe.Text = (e.JefeId).ToString();

            //btnEliminar.Text = e.Activo == 0 ? "Habilitar" : "Eliminar";
        }
        private string ObtenerBarrio(int idBarrio)
        {
            string resultado = "";
            DataTable tablaResultado = BarrioDAO.ObtenerBarrioxId(idBarrio);
            if (tablaResultado.Rows.Count > 0)
            {
                resultado = tablaResultado.Rows[0][1].ToString();
            }
            return resultado;
        }
        private string EstadoEmpleado(bool estado)
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
        private void rbtn_todos_CheckedChanged(object sender, EventArgs e)
        {
            grillaEmpleados.DataSource = EmpleadoDAO.obtenerTablaEmpleados(); ;
        }

        private void rbtn_inactivos_CheckedChanged(object sender, EventArgs e)
        {
            grillaEmpleados.DataSource = EmpleadoDAO.obtenerListadoEmpleadosInactivos();
        }

        private void rbtn_todos_CheckedChanged_1(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void rbtn_activos_CheckedChanged(object sender, EventArgs e)
        {
            grillaEmpleados.DataSource = EmpleadoDAO.obtenerListadoEmpleadosActivos();
        }
        private void CargarComboEmpleado()
        {

            DataTable tabla = EmpleadoDAO.obtenerTablaEmpleados();



            cbBuscarEmpleado.DataSource = tabla;
            cbBuscarEmpleado.DisplayMember = "empleado_id";
            cbBuscarEmpleado.ValueMember = "empleado_id";
            cbBuscarEmpleado.SelectedIndex = -1;



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int empleado_id = -3;
            if (cbBuscarEmpleado.SelectedIndex != -1)
            {
                empleado_id = (int)cbBuscarEmpleado.SelectedValue;

                grillaEmpleados.DataSource = EmpleadoDAO.obtenerTablaEmpleadoById(empleado_id);

            }
            else
            {
                MessageBox.Show("Seleccione un empleado");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            RegistrarEmpleado ventana = new RegistrarEmpleado();
            ventana.ShowDialog();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int posicionSeleccionada = grillaEmpleados.CurrentRow.Index;
            DataGridViewRow filaSeleccionada = grillaEmpleados.Rows[posicionSeleccionada];
            int index = int.Parse(filaSeleccionada.Cells["empleado_id"].Value.ToString());
            string msg_confirmacion = "";
            int value;
            string msgExito;
            if ((filaSeleccionada.Cells["empleado_activo"].Value.ToString() == "1"))
            {
                msg_confirmacion = "Seguro que desea eliminar el empleado: \n\n Nombre: " + filaSeleccionada.Cells["empleado_nombre"].Value.ToString() +
                   "\n\n ID: " + filaSeleccionada.Cells["empleado_id"].Value.ToString();
                value = 0;
                msgExito = "Empleado eliminado con exito";
                DialogResult dialogResult = MessageBox.Show(msg_confirmacion, "Confirmacion", MessageBoxButtons.YesNo);


                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {

                        bool resultado = EmpleadoDAO.EliminarEmpleado(index, value);
                        if (resultado)
                        {
                            MessageBox.Show(msgExito);

                            CargarGrilla();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar empleado");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al eliminar empleado");
                    }
                }
            }
            else
            {
                value = 0;
                MessageBox.Show("El empleado se encuentra inactivo");
                //msg_confirmacion = "El usuario seleccionado ya está inactivo";
                //msgExito = "";
                /*msg_confirmacion = "Seguro que desea habilitar el usuario el usuario: \n\n Nombre: " + filaSeleccionada.Cells["usuario_nombre"].Value.ToString() +
                 "\n\n ID: " + filaSeleccionada.Cells["usuario_id"].Value.ToString() + " \n\n Si se habilita el usuario podra acceder nuevamente al sistema.";
                value = 1;
                msgExito = "Usuario habilitado con exito";*/

            }


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = grillaEmpleados.Rows[grillaEmpleados.CurrentCell.RowIndex];
            int idEmp = int.Parse(filaSeleccionada.Cells["empleado_id"].Value.ToString());
            Empleado emp = EmpleadoDAO.obtenerEmpleadoById(idEmp);

            //ModificarEmpleado modificarEmpleado = new ModificarEmpleado(emp, idEmp);
            ModificarEmpleado modificarEmpleado = new ModificarEmpleado(idEmp);
            modificarEmpleado.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            modificarEmpleado.Show();
        }
        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            CargarGrilla();
            CargarComboEmpleado(); ;
        }
    }
}
