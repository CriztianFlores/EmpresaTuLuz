using EmpresaTuLuz.Entidades;
using EmpresaTuLuz.DAO;

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
    public partial class ModificarUsuario : Form
    {
        Usuario user;
        int userId;
        int parametroValidacion = 1;
        public ModificarUsuario(Usuario u, int id)
        {
            user = u;
            userId = id;
            bool isNewUser = u.Username == null;
            InitializeComponent();
            if (!isNewUser)
            {
                cargarCampos(u);
                parametroValidacion = 2;

            }
            cargarComboEmpleado();
        }
        private void cargarCampos(Usuario u)
        {

            txtNombreUsuario.Text = u.Username;
            txtPassword.Text = u.Password;
            txtRepetirPassword.Text = u.Password;
            cbEmpleadoId.SelectedValue = u.EmpleadoId;

           cargarEmpleado(u.EmpleadoId);


            
        }
        private void cargarEmpleado(int id)
        {


            Empleado e = EmpleadoDAO.obtenerEmpleadoById(id);

            txtEmpleadoNombre.Text = e.Nombre;
            txtEmpleadoApellido.Text = e.Apellido;
            txtEmpleadoTipoDni.Text = (e.TipoDoc == "1") ? "DNI" : "Pasaporte";
            txtEmpleadoNumeroDni.Text = e.NumDoc;

        }
        private void cargarComboEmpleado()
        {

            DataTable tabla = EmpleadoDAO.obtenerTablaEmpleados();

            cbEmpleadoId.DataSource = tabla;
            cbEmpleadoId.DisplayMember = "empleado_id";
            cbEmpleadoId.ValueMember = "empleado_id";
            cbEmpleadoId.SelectedIndex = user.EmpleadoId-1;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Si cancela la operacion los cambios no serán registrados. Seguro que Desea cancelar?", "Confirmacion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            { this.Close(); }
            }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView itemSeleccionado = (DataRowView)cbEmpleadoId.SelectedItem;
                int emp_id = int.Parse(itemSeleccionado["empleado_id"].ToString());
                cargarEmpleado(emp_id);


            }

            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea realmente modificar al usuario?", "Confirmacion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (esUsuarioValido(parametroValidacion))
                {
                    if (parametroValidacion == 2) { 
                    try
                    {
     
                        Usuario u = new Usuario(txtNombreUsuario.Text, txtPassword.Text, (int)cbEmpleadoId.SelectedValue, user.Activo);
                        bool resultado = UsuarioDAO.actualizarUsuario(u, userId);
                        if (resultado)
                        {
                            MessageBox.Show("Usuario modificado con exito");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al modificar usuario");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al modificar usuario");
                        txtNombreUsuario.Focus();
                    }
                    }
                    else
                    {

                        try
                        {
                            int estado_invalido = 1;
                            //Crear usuario
                            Usuario u = new Usuario(txtNombreUsuario.Text, txtPassword.Text, (int)cbEmpleadoId.SelectedValue, estado_invalido);
                            bool resultado = UsuarioDAO.registrarUsuario(u);
                            if (resultado)
                            {
                                MessageBox.Show("Usuario registrado con exito");
                                this.Close();


                            }
                            else
                            {
                                MessageBox.Show("Error al registrar nuevo usuario");
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error al registrar nuevo usuario");
                            txtNombreUsuario.Focus();
                        }
                    }

                }

            }
        }
   

    public bool esUsuarioValido(int parametro)
   {

            //Variables para los datos
       string nombreUser = txtNombreUsuario.Text;
        string passUser = txtPassword.Text;
        int empleado_id = 0;
        byte estado;
        bool esInactivo = false;
        if (esInactivo)
        {
            estado = 1;
        }
        else
        {
            estado = 0;
        }


        //Validar espacios en blanco
        bool tieneUsuario = false;
        bool tienePassword = false;
        bool tieneEmpleado = false;
        bool passCoinciden = false;
        bool existeEnLaGrilla = true;

        if (nombreUser.Equals(""))
        {
            MessageBox.Show("Ingrese el nombre de usuario");
            txtNombreUsuario.Focus();
        }
        else if (nombreUser.Length > 50)
        {
            MessageBox.Show("El usuario puede tener un largo maximo de 50 caracteres");
                txtNombreUsuario.Focus();
        }
        else
        {
            tieneUsuario = true;
        }

        if (txtPassword.Text.Equals(""))
        {
            MessageBox.Show("Ingrese el password de usuario");
            txtPassword.Focus();
        }
        else if (passUser.Length > 50)
        {
            MessageBox.Show("El password puede tener un largo maximo de 50 caracteres");
            txtPassword.Focus();
        }
        else
        {
            tienePassword = true;
        }

        if (!passUser.Equals(txtRepetirPassword.Text))
        {
            MessageBox.Show("Las passwords no coinciden");
        }
        else
        {
            passCoinciden = true;
        }

        if (cbEmpleadoId.SelectedIndex == -1)
        {
            MessageBox.Show("Seleccione el id del empleado asociado al nuevo usuario");
            cbEmpleadoId.Focus();
        }
        else
        {
            tieneEmpleado = true;
            empleado_id = (int)cbEmpleadoId.SelectedValue;
        }

        if (tieneUsuario && tienePassword && tieneEmpleado && passCoinciden)
        {
            //Validar existencia en grilla
   
            existeEnLaGrilla = UsuarioDAO.obtenerUsuarioByName(nombreUser).Username != null && UsuarioDAO.obtenerUsuarioByName(nombreUser).Username != user.Username;


                if (existeEnLaGrilla)
            {
           
                MessageBox.Show("El usuario ingresado ya existe. Ingrese otro usuario");
                txtNombreUsuario.Focus();
            }
        }
        return !existeEnLaGrilla;
    }
}
}
