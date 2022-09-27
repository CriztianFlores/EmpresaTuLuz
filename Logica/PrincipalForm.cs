using EmpresaTuLuz.Entidades;
using EmpresaTuLuz.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaTuLuz
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm(Usuario user)
        {
            InitializeComponent();
        }

        private void registrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarCliente ventanaRegCliente = new RegistrarCliente();
            ventanaRegCliente.Show();
        }

        private void registrarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarEmpleado ventanaRegEmpleado = new RegistrarEmpleado();
            ventanaRegEmpleado.Show();
        }

        private void registrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados ventanaUsuarios = new Empleados();
            ventanaUsuarios.Show();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Proveedores ventanaProveedores = new Proveedores();
            //ventanaProveedores.Show();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Empleados ventanaEmpleados = new Empleados();
            //ventanaEmpleados.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //RegistrarCliente ventanaClientes = new RegistrarCliente();
            //ventanaClientes.Show();
        }
    }
}
