namespace EmpresaTuLuz
{
    partial class Empleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.gbListadoUsuarios = new System.Windows.Forms.GroupBox();
            this.grillaUsuarios = new System.Windows.Forms.DataGridView();
            this.usuario_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_todos = new System.Windows.Forms.RadioButton();
            this.rbtn_activos = new System.Windows.Forms.RadioButton();
            this.rbtn_inactivos = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBuscarEmpleado = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEmpleadoNumeroDni = new System.Windows.Forms.Label();
            this.txtEmpleadoTipoDni = new System.Windows.Forms.Label();
            this.txtEmpleadoApellido = new System.Windows.Forms.Label();
            this.txtEmpleadoNombre = new System.Windows.Forms.Label();
            this.lnlNumeroDni = new System.Windows.Forms.Label();
            this.lblTipoDniEmpleado = new System.Windows.Forms.Label();
            this.lblApellidoEmpleado = new System.Windows.Forms.Label();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.gbListadoUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(78, 326);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarUsuario.TabIndex = 1;
            this.btnAgregarUsuario.Text = "Registrar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // gbListadoUsuarios
            // 
            this.gbListadoUsuarios.Controls.Add(this.grillaUsuarios);
            this.gbListadoUsuarios.Location = new System.Drawing.Point(380, 12);
            this.gbListadoUsuarios.Name = "gbListadoUsuarios";
            this.gbListadoUsuarios.Size = new System.Drawing.Size(452, 308);
            this.gbListadoUsuarios.TabIndex = 3;
            this.gbListadoUsuarios.TabStop = false;
            this.gbListadoUsuarios.Text = "Listado de usuarios";
            // 
            // grillaUsuarios
            // 
            this.grillaUsuarios.AllowUserToAddRows = false;
            this.grillaUsuarios.AllowUserToDeleteRows = false;
            this.grillaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuario_id,
            this.usuario_nombre,
            this.usuario_pass,
            this.empleado_id,
            this.usuario_activo});
            this.grillaUsuarios.Location = new System.Drawing.Point(22, 19);
            this.grillaUsuarios.Name = "grillaUsuarios";
            this.grillaUsuarios.ReadOnly = true;
            this.grillaUsuarios.Size = new System.Drawing.Size(414, 271);
            this.grillaUsuarios.TabIndex = 0;
            this.grillaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaUsuarios_CellClick);
            // 
            // usuario_id
            // 
            this.usuario_id.DataPropertyName = "usuario_id";
            this.usuario_id.HeaderText = "ID";
            this.usuario_id.Name = "usuario_id";
            this.usuario_id.ReadOnly = true;
            this.usuario_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.usuario_id.Width = 20;
            // 
            // usuario_nombre
            // 
            this.usuario_nombre.DataPropertyName = "usuario_nombre";
            this.usuario_nombre.HeaderText = "NOMBRE";
            this.usuario_nombre.Name = "usuario_nombre";
            this.usuario_nombre.ReadOnly = true;
            this.usuario_nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // usuario_pass
            // 
            this.usuario_pass.DataPropertyName = "usuario_pass";
            this.usuario_pass.HeaderText = "PASSWORD";
            this.usuario_pass.Name = "usuario_pass";
            this.usuario_pass.ReadOnly = true;
            // 
            // empleado_id
            // 
            this.empleado_id.DataPropertyName = "empleado_id";
            this.empleado_id.HeaderText = "ID EMPLEADO";
            this.empleado_id.Name = "empleado_id";
            this.empleado_id.ReadOnly = true;
            this.empleado_id.Width = 80;
            // 
            // usuario_activo
            // 
            this.usuario_activo.DataPropertyName = "usuario_activo";
            this.usuario_activo.HeaderText = "INACTIVO [0:SI] [1:NO]";
            this.usuario_activo.Name = "usuario_activo";
            this.usuario_activo.ReadOnly = true;
            this.usuario_activo.Width = 70;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(267, 326);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(170, 326);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(757, 343);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Filtrar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_todos);
            this.groupBox1.Controls.Add(this.rbtn_activos);
            this.groupBox1.Controls.Add(this.rbtn_inactivos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbBuscarEmpleado);
            this.groupBox1.Location = new System.Drawing.Point(380, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 86);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda por patron";
            // 
            // rbtn_todos
            // 
            this.rbtn_todos.AutoSize = true;
            this.rbtn_todos.Checked = true;
            this.rbtn_todos.Location = new System.Drawing.Point(53, 23);
            this.rbtn_todos.Name = "rbtn_todos";
            this.rbtn_todos.Size = new System.Drawing.Size(55, 17);
            this.rbtn_todos.TabIndex = 13;
            this.rbtn_todos.TabStop = true;
            this.rbtn_todos.Text = "Todos";
            this.rbtn_todos.UseVisualStyleBackColor = true;
            this.rbtn_todos.CheckedChanged += new System.EventHandler(this.rbtn_todos_CheckedChanged);
            // 
            // rbtn_activos
            // 
            this.rbtn_activos.AutoSize = true;
            this.rbtn_activos.Location = new System.Drawing.Point(226, 23);
            this.rbtn_activos.Name = "rbtn_activos";
            this.rbtn_activos.Size = new System.Drawing.Size(60, 17);
            this.rbtn_activos.TabIndex = 12;
            this.rbtn_activos.Text = "Activos";
            this.rbtn_activos.UseVisualStyleBackColor = true;
            this.rbtn_activos.CheckedChanged += new System.EventHandler(this.rbtn_todos_CheckedChanged);
            // 
            // rbtn_inactivos
            // 
            this.rbtn_inactivos.AutoSize = true;
            this.rbtn_inactivos.Location = new System.Drawing.Point(130, 23);
            this.rbtn_inactivos.Name = "rbtn_inactivos";
            this.rbtn_inactivos.Size = new System.Drawing.Size(68, 17);
            this.rbtn_inactivos.TabIndex = 11;
            this.rbtn_inactivos.Text = "Inactivos";
            this.rbtn_inactivos.UseVisualStyleBackColor = true;
            this.rbtn_inactivos.CheckedChanged += new System.EventHandler(this.rbtn_todos_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID del empleado:";
            // 
            // cbBuscarEmpleado
            // 
            this.cbBuscarEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscarEmpleado.FormattingEnabled = true;
            this.cbBuscarEmpleado.Location = new System.Drawing.Point(152, 48);
            this.cbBuscarEmpleado.Name = "cbBuscarEmpleado";
            this.cbBuscarEmpleado.Size = new System.Drawing.Size(119, 21);
            this.cbBuscarEmpleado.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(741, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Mostrar todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEmpleadoNumeroDni);
            this.groupBox2.Controls.Add(this.txtEmpleadoTipoDni);
            this.groupBox2.Controls.Add(this.txtEmpleadoApellido);
            this.groupBox2.Controls.Add(this.txtEmpleadoNombre);
            this.groupBox2.Controls.Add(this.lnlNumeroDni);
            this.groupBox2.Controls.Add(this.lblTipoDniEmpleado);
            this.groupBox2.Controls.Add(this.lblApellidoEmpleado);
            this.groupBox2.Controls.Add(this.lblNombreEmpleado);
            this.groupBox2.Location = new System.Drawing.Point(26, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 142);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Empeado asociado al usuario";
            // 
            // txtEmpleadoNumeroDni
            // 
            this.txtEmpleadoNumeroDni.AutoSize = true;
            this.txtEmpleadoNumeroDni.Location = new System.Drawing.Point(98, 110);
            this.txtEmpleadoNumeroDni.Name = "txtEmpleadoNumeroDni";
            this.txtEmpleadoNumeroDni.Size = new System.Drawing.Size(0, 13);
            this.txtEmpleadoNumeroDni.TabIndex = 19;
            // 
            // txtEmpleadoTipoDni
            // 
            this.txtEmpleadoTipoDni.AutoSize = true;
            this.txtEmpleadoTipoDni.Location = new System.Drawing.Point(77, 88);
            this.txtEmpleadoTipoDni.Name = "txtEmpleadoTipoDni";
            this.txtEmpleadoTipoDni.Size = new System.Drawing.Size(0, 13);
            this.txtEmpleadoTipoDni.TabIndex = 21;
            // 
            // txtEmpleadoApellido
            // 
            this.txtEmpleadoApellido.AutoSize = true;
            this.txtEmpleadoApellido.Location = new System.Drawing.Point(77, 60);
            this.txtEmpleadoApellido.Name = "txtEmpleadoApellido";
            this.txtEmpleadoApellido.Size = new System.Drawing.Size(0, 13);
            this.txtEmpleadoApellido.TabIndex = 23;
            // 
            // txtEmpleadoNombre
            // 
            this.txtEmpleadoNombre.AutoSize = true;
            this.txtEmpleadoNombre.Location = new System.Drawing.Point(77, 32);
            this.txtEmpleadoNombre.Name = "txtEmpleadoNombre";
            this.txtEmpleadoNombre.Size = new System.Drawing.Size(0, 13);
            this.txtEmpleadoNombre.TabIndex = 24;
            // 
            // lnlNumeroDni
            // 
            this.lnlNumeroDni.AutoSize = true;
            this.lnlNumeroDni.Location = new System.Drawing.Point(21, 110);
            this.lnlNumeroDni.Name = "lnlNumeroDni";
            this.lnlNumeroDni.Size = new System.Drawing.Size(71, 13);
            this.lnlNumeroDni.TabIndex = 22;
            this.lnlNumeroDni.Text = "Numero DNi: ";
            // 
            // lblTipoDniEmpleado
            // 
            this.lblTipoDniEmpleado.AutoSize = true;
            this.lblTipoDniEmpleado.Location = new System.Drawing.Point(21, 88);
            this.lblTipoDniEmpleado.Name = "lblTipoDniEmpleado";
            this.lblTipoDniEmpleado.Size = new System.Drawing.Size(56, 13);
            this.lblTipoDniEmpleado.TabIndex = 17;
            this.lblTipoDniEmpleado.Text = "Tipo DNI: ";
            // 
            // lblApellidoEmpleado
            // 
            this.lblApellidoEmpleado.AutoSize = true;
            this.lblApellidoEmpleado.Location = new System.Drawing.Point(21, 60);
            this.lblApellidoEmpleado.Name = "lblApellidoEmpleado";
            this.lblApellidoEmpleado.Size = new System.Drawing.Size(50, 13);
            this.lblApellidoEmpleado.TabIndex = 18;
            this.lblApellidoEmpleado.Text = "Apellido: ";
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(21, 33);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(50, 13);
            this.lblNombreEmpleado.TabIndex = 20;
            this.lblNombreEmpleado.Text = "Nombre: ";
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 434);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.gbListadoUsuarios);
            this.Controls.Add(this.btnAgregarUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.gbListadoUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grillaUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.GroupBox gbListadoUsuarios;
        private System.Windows.Forms.DataGridView grillaUsuarios;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBuscarEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_activo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbtn_todos;
        private System.Windows.Forms.RadioButton rbtn_activos;
        private System.Windows.Forms.RadioButton rbtn_inactivos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtEmpleadoNumeroDni;
        private System.Windows.Forms.Label txtEmpleadoTipoDni;
        private System.Windows.Forms.Label txtEmpleadoApellido;
        private System.Windows.Forms.Label txtEmpleadoNombre;
        private System.Windows.Forms.Label lnlNumeroDni;
        private System.Windows.Forms.Label lblTipoDniEmpleado;
        private System.Windows.Forms.Label lblApellidoEmpleado;
        private System.Windows.Forms.Label lblNombreEmpleado;
    }
}