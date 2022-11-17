namespace EmpresaTuLuz.Logica
{
    partial class ABMC_Proveedores
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_todos = new System.Windows.Forms.RadioButton();
            this.rbtn_activos = new System.Windows.Forms.RadioButton();
            this.rbtn_inactivos = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBuscarProveedor = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.groupBoxProveedores = new System.Windows.Forms.GroupBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.grillaProveedores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.proveedor_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor_activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBoxProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(-236, -38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(145, 29);
            this.lblTitulo.TabIndex = 31;
            this.lblTitulo.Text = "Empleados";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1136, 464);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 35);
            this.button1.TabIndex = 30;
            this.button1.Text = "Mostrar todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_todos);
            this.groupBox1.Controls.Add(this.rbtn_activos);
            this.groupBox1.Controls.Add(this.rbtn_inactivos);
            this.groupBox1.Location = new System.Drawing.Point(41, 243);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(490, 74);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda por patron";
            // 
            // rbtn_todos
            // 
            this.rbtn_todos.AutoSize = true;
            this.rbtn_todos.Checked = true;
            this.rbtn_todos.Location = new System.Drawing.Point(80, 35);
            this.rbtn_todos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtn_todos.Name = "rbtn_todos";
            this.rbtn_todos.Size = new System.Drawing.Size(78, 24);
            this.rbtn_todos.TabIndex = 13;
            this.rbtn_todos.TabStop = true;
            this.rbtn_todos.Text = "Todos";
            this.rbtn_todos.UseVisualStyleBackColor = true;
            this.rbtn_todos.CheckedChanged += new System.EventHandler(this.rbtn_todos_CheckedChanged);
            // 
            // rbtn_activos
            // 
            this.rbtn_activos.AutoSize = true;
            this.rbtn_activos.Location = new System.Drawing.Point(339, 35);
            this.rbtn_activos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtn_activos.Name = "rbtn_activos";
            this.rbtn_activos.Size = new System.Drawing.Size(85, 24);
            this.rbtn_activos.TabIndex = 12;
            this.rbtn_activos.Text = "Activos";
            this.rbtn_activos.UseVisualStyleBackColor = true;
            this.rbtn_activos.CheckedChanged += new System.EventHandler(this.rbtn_activos_CheckedChanged);
            // 
            // rbtn_inactivos
            // 
            this.rbtn_inactivos.AutoSize = true;
            this.rbtn_inactivos.Location = new System.Drawing.Point(195, 35);
            this.rbtn_inactivos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtn_inactivos.Name = "rbtn_inactivos";
            this.rbtn_inactivos.Size = new System.Drawing.Size(97, 24);
            this.rbtn_inactivos.TabIndex = 11;
            this.rbtn_inactivos.Text = "Inactivos";
            this.rbtn_inactivos.UseVisualStyleBackColor = true;
            this.rbtn_inactivos.CheckedChanged += new System.EventHandler(this.rbtn_inactivos_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 358);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Proveedor:";
            // 
            // cmbBuscarProveedor
            // 
            this.cmbBuscarProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarProveedor.FormattingEnabled = true;
            this.cmbBuscarProveedor.Location = new System.Drawing.Point(195, 355);
            this.cmbBuscarProveedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBuscarProveedor.Name = "cmbBuscarProveedor";
            this.cmbBuscarProveedor.Size = new System.Drawing.Size(176, 28);
            this.cmbBuscarProveedor.TabIndex = 21;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(405, 352);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 35);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Filtrar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(235, 464);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 35);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(380, 464);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(112, 35);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(97, 464);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(112, 35);
            this.btnAgregarUsuario.TabIndex = 25;
            this.btnAgregarUsuario.Text = "Registrar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // groupBoxProveedores
            // 
            this.groupBoxProveedores.Controls.Add(this.txtEstado);
            this.groupBoxProveedores.Controls.Add(this.label4);
            this.groupBoxProveedores.Controls.Add(this.txtTelefono);
            this.groupBoxProveedores.Controls.Add(this.label3);
            this.groupBoxProveedores.Controls.Add(this.txtId);
            this.groupBoxProveedores.Controls.Add(this.label2);
            this.groupBoxProveedores.Controls.Add(this.txtMail);
            this.groupBoxProveedores.Controls.Add(this.lblMail);
            this.groupBoxProveedores.Controls.Add(this.txtRazonSocial);
            this.groupBoxProveedores.Controls.Add(this.lblRazonSocial);
            this.groupBoxProveedores.Location = new System.Drawing.Point(24, 74);
            this.groupBoxProveedores.Name = "groupBoxProveedores";
            this.groupBoxProveedores.Size = new System.Drawing.Size(484, 161);
            this.groupBoxProveedores.TabIndex = 24;
            this.groupBoxProveedores.TabStop = false;
            this.groupBoxProveedores.Text = "Datos Proveedor";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(375, 115);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(106, 30);
            this.txtEstado.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Estado";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(145, 120);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(186, 30);
            this.txtTelefono.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Teléfono";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(375, 43);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(106, 30);
            this.txtId.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            // 
            // txtMail
            // 
            this.txtMail.Enabled = false;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(145, 75);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(184, 30);
            this.txtMail.TabIndex = 5;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(12, 75);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(48, 25);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "Mail";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Enabled = false;
            this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(145, 32);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(184, 30);
            this.txtRazonSocial.TabIndex = 3;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(12, 37);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(127, 25);
            this.lblRazonSocial.TabIndex = 2;
            this.lblRazonSocial.Text = "Razon Social";
            // 
            // grillaProveedores
            // 
            this.grillaProveedores.AllowUserToAddRows = false;
            this.grillaProveedores.AllowUserToDeleteRows = false;
            this.grillaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proveedor_id,
            this.razon_social,
            this.mail,
            this.telefono,
            this.proveedor_activo});
            this.grillaProveedores.Location = new System.Drawing.Point(556, 55);
            this.grillaProveedores.Name = "grillaProveedores";
            this.grillaProveedores.ReadOnly = true;
            this.grillaProveedores.RowHeadersWidth = 62;
            this.grillaProveedores.RowTemplate.Height = 28;
            this.grillaProveedores.Size = new System.Drawing.Size(744, 365);
            this.grillaProveedores.TabIndex = 23;
            this.grillaProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaProveedores_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Proveedores";
            // 
            // proveedor_id
            // 
            this.proveedor_id.DataPropertyName = "proveedor_id";
            this.proveedor_id.HeaderText = "ID";
            this.proveedor_id.MinimumWidth = 8;
            this.proveedor_id.Name = "proveedor_id";
            this.proveedor_id.ReadOnly = true;
            this.proveedor_id.Width = 40;
            // 
            // razon_social
            // 
            this.razon_social.DataPropertyName = "razon_social";
            this.razon_social.HeaderText = "Razon Social";
            this.razon_social.MinimumWidth = 8;
            this.razon_social.Name = "razon_social";
            this.razon_social.ReadOnly = true;
            this.razon_social.Width = 150;
            // 
            // mail
            // 
            this.mail.DataPropertyName = "mail";
            this.mail.HeaderText = "Mail";
            this.mail.MinimumWidth = 8;
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            this.mail.Width = 150;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.MinimumWidth = 8;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 150;
            // 
            // proveedor_activo
            // 
            this.proveedor_activo.DataPropertyName = "proveedor_activo";
            this.proveedor_activo.HeaderText = "Estado Activo";
            this.proveedor_activo.MinimumWidth = 8;
            this.proveedor_activo.Name = "proveedor_activo";
            this.proveedor_activo.ReadOnly = true;
            this.proveedor_activo.Width = 80;
            // 
            // proveedores_boris_abmc1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBuscarProveedor);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.groupBoxProveedores);
            this.Controls.Add(this.grillaProveedores);
            this.Name = "proveedores_boris_abmc1";
            this.Text = "proveedores_boris_abmc1";
            this.Load += new System.EventHandler(this.ABMC_Proveedores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxProveedores.ResumeLayout(false);
            this.groupBoxProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_todos;
        private System.Windows.Forms.RadioButton rbtn_activos;
        private System.Windows.Forms.RadioButton rbtn_inactivos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBuscarProveedor;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.GroupBox groupBoxProveedores;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.DataGridView grillaProveedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor_activo;
    }
}