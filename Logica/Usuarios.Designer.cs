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
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.chkInactivo = new System.Windows.Forms.CheckBox();
            this.lblEmpleadoId = new System.Windows.Forms.Label();
            this.cbEmpleadoId = new System.Windows.Forms.ComboBox();
            this.txtRepetirPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbListadoUsuarios = new System.Windows.Forms.GroupBox();
            this.grillaUsuarios = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBuscarEmpleado = new System.Windows.Forms.ComboBox();
            this.usuario_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.gbUsuario.SuspendLayout();
            this.gbListadoUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.chkInactivo);
            this.gbUsuario.Controls.Add(this.lblEmpleadoId);
            this.gbUsuario.Controls.Add(this.cbEmpleadoId);
            this.gbUsuario.Controls.Add(this.txtRepetirPassword);
            this.gbUsuario.Controls.Add(this.txtPassword);
            this.gbUsuario.Controls.Add(this.txtUsuario);
            this.gbUsuario.Controls.Add(this.label3);
            this.gbUsuario.Controls.Add(this.label2);
            this.gbUsuario.Controls.Add(this.lblUsuario);
            this.gbUsuario.Location = new System.Drawing.Point(27, 12);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(332, 177);
            this.gbUsuario.TabIndex = 0;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Datos de usuario";
            // 
            // chkInactivo
            // 
            this.chkInactivo.AutoSize = true;
            this.chkInactivo.Location = new System.Drawing.Point(130, 140);
            this.chkInactivo.Name = "chkInactivo";
            this.chkInactivo.Size = new System.Drawing.Size(114, 17);
            this.chkInactivo.TabIndex = 8;
            this.chkInactivo.Text = "En estado inactivo";
            this.chkInactivo.UseVisualStyleBackColor = true;
            // 
            // lblEmpleadoId
            // 
            this.lblEmpleadoId.AutoSize = true;
            this.lblEmpleadoId.Location = new System.Drawing.Point(62, 116);
            this.lblEmpleadoId.Name = "lblEmpleadoId";
            this.lblEmpleadoId.Size = new System.Drawing.Size(87, 13);
            this.lblEmpleadoId.TabIndex = 7;
            this.lblEmpleadoId.Text = "ID del empleado:";
            // 
            // cbEmpleadoId
            // 
            this.cbEmpleadoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleadoId.FormattingEnabled = true;
            this.cbEmpleadoId.Location = new System.Drawing.Point(155, 113);
            this.cbEmpleadoId.Name = "cbEmpleadoId";
            this.cbEmpleadoId.Size = new System.Drawing.Size(119, 21);
            this.cbEmpleadoId.TabIndex = 6;
            // 
            // txtRepetirPassword
            // 
            this.txtRepetirPassword.Location = new System.Drawing.Point(155, 86);
            this.txtRepetirPassword.Name = "txtRepetirPassword";
            this.txtRepetirPassword.PasswordChar = '*';
            this.txtRepetirPassword.Size = new System.Drawing.Size(119, 20);
            this.txtRepetirPassword.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(155, 60);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(119, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(155, 34);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(119, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repetir password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(103, 37);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(226, 205);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarUsuario.TabIndex = 1;
            this.btnAgregarUsuario.Text = "Registrar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(73, 267);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(226, 267);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(226, 326);
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
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbBuscarEmpleado);
            this.groupBox1.Location = new System.Drawing.Point(380, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 86);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda por patron";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID del empleado:";
            // 
            // cbBuscarEmpleado
            // 
            this.cbBuscarEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscarEmpleado.FormattingEnabled = true;
            this.cbBuscarEmpleado.Location = new System.Drawing.Point(174, 37);
            this.cbBuscarEmpleado.Name = "cbBuscarEmpleado";
            this.cbBuscarEmpleado.Size = new System.Drawing.Size(119, 21);
            this.cbBuscarEmpleado.TabIndex = 9;
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
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 434);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.gbListadoUsuarios);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.gbUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            this.gbListadoUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grillaUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.TextBox txtRepetirPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gbListadoUsuarios;
        private System.Windows.Forms.DataGridView grillaUsuarios;
        private System.Windows.Forms.Label lblEmpleadoId;
        private System.Windows.Forms.ComboBox cbEmpleadoId;
        private System.Windows.Forms.CheckBox chkInactivo;
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
    }
}