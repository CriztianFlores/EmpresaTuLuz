namespace EmpresaTuLuz.Logica
{
    partial class ABMC_Empleados
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_todos = new System.Windows.Forms.RadioButton();
            this.rbtn_activos = new System.Windows.Forms.RadioButton();
            this.rbtn_inactivos = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBuscarEmpleado = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.groupBoxEmpleados = new System.Windows.Forms.GroupBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipoDoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDoc = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.grillaEmpleados = new System.Windows.Forms.DataGridView();
            this.empleado_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado_activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado_num_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado_tipo_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrio_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_jefe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtIdJefe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1122, 433);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "Mostrar todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_todos);
            this.groupBox1.Controls.Add(this.rbtn_activos);
            this.groupBox1.Controls.Add(this.rbtn_inactivos);
            this.groupBox1.Location = new System.Drawing.Point(510, 409);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(573, 74);
            this.groupBox1.TabIndex = 18;
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
            this.rbtn_todos.CheckedChanged += new System.EventHandler(this.rbtn_todos_CheckedChanged_1);
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
            this.label5.Location = new System.Drawing.Point(516, 497);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID del empleado:";
            // 
            // cbBuscarEmpleado
            // 
            this.cbBuscarEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscarEmpleado.FormattingEnabled = true;
            this.cbBuscarEmpleado.Location = new System.Drawing.Point(656, 493);
            this.cbBuscarEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBuscarEmpleado.Name = "cbBuscarEmpleado";
            this.cbBuscarEmpleado.Size = new System.Drawing.Size(176, 28);
            this.cbBuscarEmpleado.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(866, 490);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 35);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Filtrar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(196, 448);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 35);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(341, 448);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(112, 35);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(58, 448);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(112, 35);
            this.btnAgregarUsuario.TabIndex = 14;
            this.btnAgregarUsuario.Text = "Registrar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // groupBoxEmpleados
            // 
            this.groupBoxEmpleados.Controls.Add(this.label6);
            this.groupBoxEmpleados.Controls.Add(this.txtIdJefe);
            this.groupBoxEmpleados.Controls.Add(this.txtEstado);
            this.groupBoxEmpleados.Controls.Add(this.label4);
            this.groupBoxEmpleados.Controls.Add(this.txtTelefono);
            this.groupBoxEmpleados.Controls.Add(this.label3);
            this.groupBoxEmpleados.Controls.Add(this.txtBarrio);
            this.groupBoxEmpleados.Controls.Add(this.lblBarrio);
            this.groupBoxEmpleados.Controls.Add(this.txtDireccion);
            this.groupBoxEmpleados.Controls.Add(this.lblDireccion);
            this.groupBoxEmpleados.Controls.Add(this.txtId);
            this.groupBoxEmpleados.Controls.Add(this.label2);
            this.groupBoxEmpleados.Controls.Add(this.txtTipoDoc);
            this.groupBoxEmpleados.Controls.Add(this.label1);
            this.groupBoxEmpleados.Controls.Add(this.txtDocumento);
            this.groupBoxEmpleados.Controls.Add(this.lblDoc);
            this.groupBoxEmpleados.Controls.Add(this.txtNombre);
            this.groupBoxEmpleados.Controls.Add(this.lblNombre);
            this.groupBoxEmpleados.Controls.Add(this.txtApellido);
            this.groupBoxEmpleados.Controls.Add(this.lblApellido);
            this.groupBoxEmpleados.Location = new System.Drawing.Point(10, 31);
            this.groupBoxEmpleados.Name = "groupBoxEmpleados";
            this.groupBoxEmpleados.Size = new System.Drawing.Size(484, 346);
            this.groupBoxEmpleados.TabIndex = 13;
            this.groupBoxEmpleados.TabStop = false;
            this.groupBoxEmpleados.Text = "Datos Empleado";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(372, 142);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(106, 30);
            this.txtEstado.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Estado";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(133, 260);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(170, 30);
            this.txtTelefono.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Teléfono";
            // 
            // txtBarrio
            // 
            this.txtBarrio.Enabled = false;
            this.txtBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarrio.Location = new System.Drawing.Point(133, 222);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(170, 30);
            this.txtBarrio.TabIndex = 15;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(15, 222);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(63, 25);
            this.lblBarrio.TabIndex = 14;
            this.lblBarrio.Text = "Barrio";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(133, 186);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(170, 30);
            this.txtDireccion.TabIndex = 13;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(15, 189);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(93, 25);
            this.lblDireccion.TabIndex = 12;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(372, 70);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(106, 30);
            this.txtId.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            // 
            // txtTipoDoc
            // 
            this.txtTipoDoc.Enabled = false;
            this.txtTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoDoc.Location = new System.Drawing.Point(174, 147);
            this.txtTipoDoc.Name = "txtTipoDoc";
            this.txtTipoDoc.Size = new System.Drawing.Size(126, 30);
            this.txtTipoDoc.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tipo Documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Enabled = false;
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(130, 111);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(170, 30);
            this.txtDocumento.TabIndex = 7;
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoc.Location = new System.Drawing.Point(12, 114);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(112, 25);
            this.lblDoc.TabIndex = 6;
            this.lblDoc.Text = "Documento";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(116, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(184, 30);
            this.txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 25);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(116, 37);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(184, 30);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(12, 37);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(82, 25);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // grillaEmpleados
            // 
            this.grillaEmpleados.AllowUserToAddRows = false;
            this.grillaEmpleados.AllowUserToDeleteRows = false;
            this.grillaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empleado_nombre,
            this.empleado_apellido,
            this.empleado_id,
            this.empleado_activo,
            this.empleado_num_doc,
            this.empleado_tipo_doc,
            this.direccion,
            this.barrio_id,
            this.telefono,
            this.id_jefe});
            this.grillaEmpleados.Location = new System.Drawing.Point(542, 12);
            this.grillaEmpleados.Name = "grillaEmpleados";
            this.grillaEmpleados.ReadOnly = true;
            this.grillaEmpleados.RowHeadersWidth = 62;
            this.grillaEmpleados.RowTemplate.Height = 28;
            this.grillaEmpleados.Size = new System.Drawing.Size(744, 365);
            this.grillaEmpleados.TabIndex = 12;
            this.grillaEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaEmpleados_CellClick);
            // 
            // empleado_nombre
            // 
            this.empleado_nombre.DataPropertyName = "empleado_nombre";
            this.empleado_nombre.HeaderText = "Nombre";
            this.empleado_nombre.MinimumWidth = 8;
            this.empleado_nombre.Name = "empleado_nombre";
            this.empleado_nombre.ReadOnly = true;
            this.empleado_nombre.Width = 200;
            // 
            // empleado_apellido
            // 
            this.empleado_apellido.DataPropertyName = "empleado_apellido";
            this.empleado_apellido.HeaderText = "Apellido";
            this.empleado_apellido.MinimumWidth = 8;
            this.empleado_apellido.Name = "empleado_apellido";
            this.empleado_apellido.ReadOnly = true;
            this.empleado_apellido.Width = 200;
            // 
            // empleado_id
            // 
            this.empleado_id.DataPropertyName = "empleado_id";
            this.empleado_id.HeaderText = "ID";
            this.empleado_id.MinimumWidth = 8;
            this.empleado_id.Name = "empleado_id";
            this.empleado_id.ReadOnly = true;
            this.empleado_id.Width = 40;
            // 
            // empleado_activo
            // 
            this.empleado_activo.DataPropertyName = "empleado_activo";
            this.empleado_activo.HeaderText = "Estado";
            this.empleado_activo.MinimumWidth = 8;
            this.empleado_activo.Name = "empleado_activo";
            this.empleado_activo.ReadOnly = true;
            this.empleado_activo.Width = 150;
            // 
            // empleado_num_doc
            // 
            this.empleado_num_doc.DataPropertyName = "empleado_num_doc";
            this.empleado_num_doc.HeaderText = "Documento";
            this.empleado_num_doc.MinimumWidth = 8;
            this.empleado_num_doc.Name = "empleado_num_doc";
            this.empleado_num_doc.ReadOnly = true;
            this.empleado_num_doc.Visible = false;
            this.empleado_num_doc.Width = 150;
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
            // id_jefe
            // 
            this.id_jefe.DataPropertyName = "id_jefe";
            this.id_jefe.HeaderText = "ID JEFE";
            this.id_jefe.MinimumWidth = 8;
            this.id_jefe.Name = "id_jefe";
            this.id_jefe.ReadOnly = true;
            this.id_jefe.Visible = false;
            this.id_jefe.Width = 40;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, -1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(145, 29);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "Empleados";
            // 
            // txtIdJefe
            // 
            this.txtIdJefe.Enabled = false;
            this.txtIdJefe.Location = new System.Drawing.Point(372, 222);
            this.txtIdJefe.Name = "txtIdJefe";
            this.txtIdJefe.Size = new System.Drawing.Size(100, 26);
            this.txtIdJefe.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(387, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "ID Jefe";
            // 
            // Empleados_Boris1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 543);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbBuscarEmpleado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.groupBoxEmpleados);
            this.Controls.Add(this.grillaEmpleados);
            this.Name = "Empleados_Boris1";
            this.Text = "Empleados_Boris1";
            this.Load += new System.EventHandler(this.ABMC_Empleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxEmpleados.ResumeLayout(false);
            this.groupBoxEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_todos;
        private System.Windows.Forms.RadioButton rbtn_activos;
        private System.Windows.Forms.RadioButton rbtn_inactivos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBuscarEmpleado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.GroupBox groupBoxEmpleados;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTipoDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.DataGridView grillaEmpleados;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado_activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado_num_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado_tipo_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn barrio_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_jefe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdJefe;
    }
}