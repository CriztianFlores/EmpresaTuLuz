namespace EmpresaTuLuz
{
    partial class RegistrarEmpleado
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblNumDoc = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cbTipoDoc = new System.Windows.Forms.ComboBox();
            this.cbBarrio = new System.Windows.Forms.ComboBox();
            this.chkNoTieneJefe = new System.Windows.Forms.CheckBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbIdJefe = new System.Windows.Forms.ComboBox();
            this.lblIdJefe = new System.Windows.Forms.Label();
            this.gdrEmpleados = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado_num_Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado_tipo_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrio_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado_activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNumDoc = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdrEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(94, 42);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(94, 85);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(69, 20);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(94, 131);
            this.lblTipoDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(149, 20);
            this.lblTipoDoc.TabIndex = 2;
            this.lblTipoDoc.Text = "Tipo de documento:";
            // 
            // lblNumDoc
            // 
            this.lblNumDoc.AutoSize = true;
            this.lblNumDoc.Location = new System.Drawing.Point(94, 177);
            this.lblNumDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumDoc.Name = "lblNumDoc";
            this.lblNumDoc.Size = new System.Drawing.Size(175, 20);
            this.lblNumDoc.TabIndex = 3;
            this.lblNumDoc.Text = "Numero de documento:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(94, 222);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(79, 20);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(94, 262);
            this.lblBarrio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(55, 20);
            this.lblBarrio.TabIndex = 5;
            this.lblBarrio.Text = "Barrio:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(94, 309);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(75, 20);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(210, 305);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(169, 26);
            this.txtTelefono.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(210, 37);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 26);
            this.txtNombre.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(210, 80);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(169, 26);
            this.txtApellido.TabIndex = 11;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(210, 217);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(169, 26);
            this.txtDireccion.TabIndex = 13;
            // 
            // cbTipoDoc
            // 
            this.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDoc.FormattingEnabled = true;
            this.cbTipoDoc.Location = new System.Drawing.Point(272, 126);
            this.cbTipoDoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTipoDoc.Name = "cbTipoDoc";
            this.cbTipoDoc.Size = new System.Drawing.Size(108, 28);
            this.cbTipoDoc.TabIndex = 14;
            // 
            // cbBarrio
            // 
            this.cbBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBarrio.FormattingEnabled = true;
            this.cbBarrio.Location = new System.Drawing.Point(210, 257);
            this.cbBarrio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBarrio.Name = "cbBarrio";
            this.cbBarrio.Size = new System.Drawing.Size(169, 28);
            this.cbBarrio.TabIndex = 15;
            // 
            // chkNoTieneJefe
            // 
            this.chkNoTieneJefe.AutoSize = true;
            this.chkNoTieneJefe.Location = new System.Drawing.Point(186, 365);
            this.chkNoTieneJefe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkNoTieneJefe.Name = "chkNoTieneJefe";
            this.chkNoTieneJefe.Size = new System.Drawing.Size(124, 24);
            this.chkNoTieneJefe.TabIndex = 17;
            this.chkNoTieneJefe.Text = "No tiene jefe";
            this.chkNoTieneJefe.UseVisualStyleBackColor = true;
            this.chkNoTieneJefe.CheckedChanged += new System.EventHandler(this.chkTieneJefe_CheckedChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(159, 565);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(112, 35);
            this.btnRegistrar.TabIndex = 18;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(38, 565);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 35);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(280, 565);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 35);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbIdJefe
            // 
            this.cbIdJefe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdJefe.FormattingEnabled = true;
            this.cbIdJefe.Location = new System.Drawing.Point(206, 400);
            this.cbIdJefe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIdJefe.Name = "cbIdJefe";
            this.cbIdJefe.Size = new System.Drawing.Size(169, 28);
            this.cbIdJefe.TabIndex = 21;
            // 
            // lblIdJefe
            // 
            this.lblIdJefe.AutoSize = true;
            this.lblIdJefe.Location = new System.Drawing.Point(94, 405);
            this.lblIdJefe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdJefe.Name = "lblIdJefe";
            this.lblIdJefe.Size = new System.Drawing.Size(85, 20);
            this.lblIdJefe.TabIndex = 22;
            this.lblIdJefe.Text = "ID del jefe:";
            // 
            // gdrEmpleados
            // 
            this.gdrEmpleados.AllowUserToAddRows = false;
            this.gdrEmpleados.AllowUserToDeleteRows = false;
            this.gdrEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.empleado_id,
            this.empleado_num_Doc,
            this.empleado_tipo_doc,
            this.direccion,
            this.barrio_id,
            this.telefono,
            this.empleado_activo});
            this.gdrEmpleados.Location = new System.Drawing.Point(468, 37);
            this.gdrEmpleados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gdrEmpleados.Name = "gdrEmpleados";
            this.gdrEmpleados.ReadOnly = true;
            this.gdrEmpleados.RowHeadersWidth = 62;
            this.gdrEmpleados.Size = new System.Drawing.Size(834, 492);
            this.gdrEmpleados.TabIndex = 23;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "empleado_nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "empleado_apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 8;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 250;
            // 
            // empleado_id
            // 
            this.empleado_id.DataPropertyName = "empleado_id";
            this.empleado_id.HeaderText = "ID";
            this.empleado_id.MinimumWidth = 8;
            this.empleado_id.Name = "empleado_id";
            this.empleado_id.ReadOnly = true;
            this.empleado_id.Width = 150;
            // 
            // empleado_num_Doc
            // 
            this.empleado_num_Doc.DataPropertyName = "empleado_num_doc";
            this.empleado_num_Doc.HeaderText = "Documento";
            this.empleado_num_Doc.MinimumWidth = 8;
            this.empleado_num_Doc.Name = "empleado_num_Doc";
            this.empleado_num_Doc.ReadOnly = true;
            this.empleado_num_Doc.Visible = false;
            this.empleado_num_Doc.Width = 150;
            // 
            // empleado_tipo_doc
            // 
            this.empleado_tipo_doc.DataPropertyName = "empleado_tipo_doc";
            this.empleado_tipo_doc.HeaderText = "Tipo Doc";
            this.empleado_tipo_doc.MinimumWidth = 8;
            this.empleado_tipo_doc.Name = "empleado_tipo_doc";
            this.empleado_tipo_doc.ReadOnly = true;
            this.empleado_tipo_doc.Visible = false;
            this.empleado_tipo_doc.Width = 150;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Direccion";
            this.direccion.MinimumWidth = 8;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Visible = false;
            this.direccion.Width = 150;
            // 
            // barrio_id
            // 
            this.barrio_id.DataPropertyName = "barrio_id";
            this.barrio_id.HeaderText = "Barrio";
            this.barrio_id.MinimumWidth = 8;
            this.barrio_id.Name = "barrio_id";
            this.barrio_id.ReadOnly = true;
            this.barrio_id.Visible = false;
            this.barrio_id.Width = 150;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.MinimumWidth = 8;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Visible = false;
            this.telefono.Width = 150;
            // 
            // empleado_activo
            // 
            this.empleado_activo.DataPropertyName = "empleado_activo";
            this.empleado_activo.HeaderText = "Activo";
            this.empleado_activo.MinimumWidth = 8;
            this.empleado_activo.Name = "empleado_activo";
            this.empleado_activo.ReadOnly = true;
            this.empleado_activo.Visible = false;
            this.empleado_activo.Width = 150;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(280, 172);
            this.txtNumDoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(98, 26);
            this.txtNumDoc.TabIndex = 12;
            this.txtNumDoc.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // RegistrarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 623);
            this.Controls.Add(this.gdrEmpleados);
            this.Controls.Add(this.lblIdJefe);
            this.Controls.Add(this.cbIdJefe);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.chkNoTieneJefe);
            this.Controls.Add(this.cbBarrio);
            this.Controls.Add(this.cbTipoDoc);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNumDoc);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegistrarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de nuevo empleado";
            this.Load += new System.EventHandler(this.RegistrarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblNumDoc;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cbTipoDoc;
        private System.Windows.Forms.ComboBox cbBarrio;
        private System.Windows.Forms.CheckBox chkNoTieneJefe;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbIdJefe;
        private System.Windows.Forms.Label lblIdJefe;
        private System.Windows.Forms.DataGridView gdrEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado_num_Doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado_tipo_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn barrio_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado_activo;
        private System.Windows.Forms.MaskedTextBox txtNumDoc;
    }
}