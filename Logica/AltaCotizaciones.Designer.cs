namespace EmpresaTuLuz.Logica
{
    partial class AltaCotizaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txtNroCotizacion = new System.Windows.Forms.TextBox();
            this.lblNroCotización = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbIdCliente = new System.Windows.Forms.ComboBox();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.groupBoxCotizacion = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.grillaProductos = new System.Windows.Forms.DataGridView();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnGuardarCotizacion = new System.Windows.Forms.Button();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.lblClienteCuit = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gpVendedor = new System.Windows.Forms.GroupBox();
            this.lblVendedorNombre_ = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblVendedorDni = new System.Windows.Forms.Label();
            this.lblVendedorNombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProductoPrecio = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCotizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).BeginInit();
            this.gpVendedor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de Nueva Cotización";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // txtfecha
            // 
            this.txtfecha.Enabled = false;
            this.txtfecha.Location = new System.Drawing.Point(362, 39);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(2);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(76, 20);
            this.txtfecha.TabIndex = 2;
            // 
            // txtNroCotizacion
            // 
            this.txtNroCotizacion.Enabled = false;
            this.txtNroCotizacion.Location = new System.Drawing.Point(127, 43);
            this.txtNroCotizacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtNroCotizacion.Name = "txtNroCotizacion";
            this.txtNroCotizacion.Size = new System.Drawing.Size(52, 20);
            this.txtNroCotizacion.TabIndex = 4;
            // 
            // lblNroCotización
            // 
            this.lblNroCotización.AutoSize = true;
            this.lblNroCotización.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCotización.Location = new System.Drawing.Point(11, 41);
            this.lblNroCotización.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNroCotización.Name = "lblNroCotización";
            this.lblNroCotización.Size = new System.Drawing.Size(112, 20);
            this.lblNroCotización.TabIndex = 3;
            this.lblNroCotización.Text = "Nro Cotizacion";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(166, 550);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(136, 20);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Tipo de cotizacion";
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // cmbIdCliente
            // 
            this.cmbIdCliente.FormattingEnabled = true;
            this.cmbIdCliente.Location = new System.Drawing.Point(80, 22);
            this.cmbIdCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIdCliente.Name = "cmbIdCliente";
            this.cmbIdCliente.Size = new System.Drawing.Size(92, 21);
            this.cmbIdCliente.TabIndex = 6;
            this.cmbIdCliente.SelectedIndexChanged += new System.EventHandler(this.cmbIdCliente_SelectedIndexChanged);
            this.cmbIdCliente.SelectionChangeCommitted += new System.EventHandler(this.cmbIdCliente_SelectionChangeCommitted);
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(85, 22);
            this.cmbVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(104, 21);
            this.cmbVendedor.TabIndex = 8;
            this.cmbVendedor.SelectedIndexChanged += new System.EventHandler(this.cmbVendedor_SelectedIndexChanged);
            this.cmbVendedor.SelectionChangeCommitted += new System.EventHandler(this.cmbVendedor_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(159, 572);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(154, 21);
            this.cmbEstado.TabIndex = 10;
            // 
            // groupBoxCotizacion
            // 
            this.groupBoxCotizacion.Controls.Add(this.txtObservaciones);
            this.groupBoxCotizacion.Controls.Add(this.label3);
            this.groupBoxCotizacion.Controls.Add(this.lblProductoPrecio);
            this.groupBoxCotizacion.Controls.Add(this.label5);
            this.groupBoxCotizacion.Controls.Add(this.btnAgregarProducto);
            this.groupBoxCotizacion.Controls.Add(this.grillaProductos);
            this.groupBoxCotizacion.Controls.Add(this.txtCantidad);
            this.groupBoxCotizacion.Controls.Add(this.txtTotal);
            this.groupBoxCotizacion.Controls.Add(this.lblCantidad);
            this.groupBoxCotizacion.Controls.Add(this.lblTotal);
            this.groupBoxCotizacion.Controls.Add(this.lblProducto);
            this.groupBoxCotizacion.Controls.Add(this.cmbProducto);
            this.groupBoxCotizacion.Location = new System.Drawing.Point(18, 191);
            this.groupBoxCotizacion.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxCotizacion.Name = "groupBoxCotizacion";
            this.groupBoxCotizacion.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxCotizacion.Size = new System.Drawing.Size(538, 357);
            this.groupBoxCotizacion.TabIndex = 11;
            this.groupBoxCotizacion.TabStop = false;
            this.groupBoxCotizacion.Text = "Productos";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(340, 303);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 20);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(385, 301);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(92, 20);
            this.txtTotal.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(128, 325);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(2);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(349, 20);
            this.txtObservaciones.TabIndex = 15;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(11, 50);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoCliente.Location = new System.Drawing.Point(11, 22);
            this.lblApellidoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(65, 20);
            this.lblApellidoCliente.TabIndex = 10;
            this.lblApellidoCliente.Text = "Apellido";
            // 
            // grillaProductos
            // 
            this.grillaProductos.AllowUserToAddRows = false;
            this.grillaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.precioUnitario});
            this.grillaProductos.Location = new System.Drawing.Point(14, 80);
            this.grillaProductos.Margin = new System.Windows.Forms.Padding(2);
            this.grillaProductos.Name = "grillaProductos";
            this.grillaProductos.ReadOnly = true;
            this.grillaProductos.RowHeadersWidth = 51;
            this.grillaProductos.RowTemplate.Height = 24;
            this.grillaProductos.Size = new System.Drawing.Size(508, 217);
            this.grillaProductos.TabIndex = 17;
            this.grillaProductos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grillaProductos_RowsAdded);
            this.grillaProductos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.grillaProductos_RowsRemoved);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(344, 17);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(62, 38);
            this.btnAgregarProducto.TabIndex = 16;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(233, 15);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 20);
            this.lblCantidad.TabIndex = 14;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.Click += new System.EventHandler(this.lblCantidad_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(224, 40);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(92, 20);
            this.txtCantidad.TabIndex = 15;
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(14, 37);
            this.cmbProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(92, 21);
            this.cmbProducto.TabIndex = 10;
            this.cmbProducto.SelectionChangeCommitted += new System.EventHandler(this.cmbProducto_SelectionChangeCommitted);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(23, 15);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(73, 20);
            this.lblProducto.TabIndex = 11;
            this.lblProducto.Text = "Producto";
            // 
            // btnGuardarCotizacion
            // 
            this.btnGuardarCotizacion.Location = new System.Drawing.Point(440, 566);
            this.btnGuardarCotizacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarCotizacion.Name = "btnGuardarCotizacion";
            this.btnGuardarCotizacion.Size = new System.Drawing.Size(116, 27);
            this.btnGuardarCotizacion.TabIndex = 13;
            this.btnGuardarCotizacion.Text = "Guardar Cotizacion";
            this.btnGuardarCotizacion.UseVisualStyleBackColor = true;
            this.btnGuardarCotizacion.Click += new System.EventHandler(this.btnGuardarCotizacion_Click);
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.AutoSize = true;
            this.lblClienteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClienteNombre.Location = new System.Drawing.Point(81, 50);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(0, 20);
            this.lblClienteNombre.TabIndex = 22;
            // 
            // lblClienteCuit
            // 
            this.lblClienteCuit.AutoSize = true;
            this.lblClienteCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClienteCuit.Location = new System.Drawing.Point(76, 75);
            this.lblClienteCuit.Name = "lblClienteCuit";
            this.lblClienteCuit.Size = new System.Drawing.Size(0, 20);
            this.lblClienteCuit.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "CUIT";
            // 
            // gpVendedor
            // 
            this.gpVendedor.Controls.Add(this.lblVendedorNombre);
            this.gpVendedor.Controls.Add(this.lblVendedorDni);
            this.gpVendedor.Controls.Add(this.label7);
            this.gpVendedor.Controls.Add(this.lblVendedorNombre_);
            this.gpVendedor.Controls.Add(this.label4);
            this.gpVendedor.Controls.Add(this.cmbVendedor);
            this.gpVendedor.Location = new System.Drawing.Point(12, 76);
            this.gpVendedor.Name = "gpVendedor";
            this.gpVendedor.Size = new System.Drawing.Size(260, 110);
            this.gpVendedor.TabIndex = 26;
            this.gpVendedor.TabStop = false;
            this.gpVendedor.Text = "Vendedor";
            this.gpVendedor.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblVendedorNombre_
            // 
            this.lblVendedorNombre_.AutoSize = true;
            this.lblVendedorNombre_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedorNombre_.Location = new System.Drawing.Point(16, 50);
            this.lblVendedorNombre_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVendedorNombre_.Name = "lblVendedorNombre_";
            this.lblVendedorNombre_.Size = new System.Drawing.Size(65, 20);
            this.lblVendedorNombre_.TabIndex = 9;
            this.lblVendedorNombre_.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "DNI";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblVendedorDni
            // 
            this.lblVendedorDni.AutoSize = true;
            this.lblVendedorDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedorDni.Location = new System.Drawing.Point(102, 75);
            this.lblVendedorDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVendedorDni.Name = "lblVendedorDni";
            this.lblVendedorDni.Size = new System.Drawing.Size(0, 20);
            this.lblVendedorDni.TabIndex = 11;
            // 
            // lblVendedorNombre
            // 
            this.lblVendedorNombre.AutoSize = true;
            this.lblVendedorNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedorNombre.Location = new System.Drawing.Point(102, 50);
            this.lblVendedorNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVendedorNombre.Name = "lblVendedorNombre";
            this.lblVendedorNombre.Size = new System.Drawing.Size(0, 20);
            this.lblVendedorNombre.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblClienteNombre);
            this.groupBox1.Controls.Add(this.lblClienteCuit);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblApellidoCliente);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.cmbIdCliente);
            this.groupBox1.Location = new System.Drawing.Point(296, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 110);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Precio";
            // 
            // lblProductoPrecio
            // 
            this.lblProductoPrecio.AutoSize = true;
            this.lblProductoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoPrecio.Location = new System.Drawing.Point(137, 38);
            this.lblProductoPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductoPrecio.Name = "lblProductoPrecio";
            this.lblProductoPrecio.Size = new System.Drawing.Size(0, 20);
            this.lblProductoPrecio.TabIndex = 19;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 40;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio X Cantidad";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 125;
            // 
            // precioUnitario
            // 
            this.precioUnitario.HeaderText = "Precio x Unidad";
            this.precioUnitario.Name = "precioUnitario";
            this.precioUnitario.ReadOnly = true;
            // 
            // AltaCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 604);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.gpVendedor);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.btnGuardarCotizacion);
            this.Controls.Add(this.groupBoxCotizacion);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNroCotización);
            this.Controls.Add(this.txtNroCotizacion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AltaCotizaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Cotizaciones";
            this.Load += new System.EventHandler(this.AltaCotizaciones_Load);
            this.groupBoxCotizacion.ResumeLayout(false);
            this.groupBoxCotizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).EndInit();
            this.gpVendedor.ResumeLayout(false);
            this.gpVendedor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txtNroCotizacion;
        private System.Windows.Forms.Label lblNroCotización;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbIdCliente;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.GroupBox groupBoxCotizacion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.DataGridView grillaProductos;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnGuardarCotizacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblClienteCuit;
        private System.Windows.Forms.Label lblClienteNombre;
        private System.Windows.Forms.GroupBox gpVendedor;
        private System.Windows.Forms.Label lblVendedorNombre;
        private System.Windows.Forms.Label lblVendedorDni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblVendedorNombre_;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblProductoPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitario;
    }
}