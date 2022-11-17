namespace EmpresaTuLuz.Logica
{
    partial class AltaVenta
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
            this.groupBoxCotizacion = new System.Windows.Forms.GroupBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProductoPrecio = new System.Windows.Forms.Label();
            this.grillaProductos = new System.Windows.Forms.DataGridView();
            this.cod_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioxCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.btnGuardarCotizacion = new System.Windows.Forms.Button();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.lblClienteCuit = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblClienteApellido = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpVendedor = new System.Windows.Forms.GroupBox();
            this.lblVendedorNombre = new System.Windows.Forms.Label();
            this.lblVendedorDni = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblVendedorNombre_ = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.cbFormaDePago = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxCotizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gpVendedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Nueva Venta";
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
            this.txtfecha.Size = new System.Drawing.Size(133, 20);
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
            // groupBoxCotizacion
            // 
            this.groupBoxCotizacion.Controls.Add(this.txtObservaciones);
            this.groupBoxCotizacion.Controls.Add(this.label3);
            this.groupBoxCotizacion.Controls.Add(this.lblProductoPrecio);
            this.groupBoxCotizacion.Controls.Add(this.grillaProductos);
            this.groupBoxCotizacion.Controls.Add(this.txtTotal);
            this.groupBoxCotizacion.Controls.Add(this.lblTotal);
            this.groupBoxCotizacion.Location = new System.Drawing.Point(18, 191);
            this.groupBoxCotizacion.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxCotizacion.Name = "groupBoxCotizacion";
            this.groupBoxCotizacion.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxCotizacion.Size = new System.Drawing.Size(538, 330);
            this.groupBoxCotizacion.TabIndex = 11;
            this.groupBoxCotizacion.TabStop = false;
            this.groupBoxCotizacion.Text = "Productos";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Enabled = false;
            this.txtObservaciones.Location = new System.Drawing.Point(128, 299);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(2);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(349, 20);
            this.txtObservaciones.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Observaciones";
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
            // grillaProductos
            // 
            this.grillaProductos.AllowUserToAddRows = false;
            this.grillaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_producto,
            this.nombre,
            this.Cantidad,
            this.PrecioxCantidad,
            this.precio});
            this.grillaProductos.Location = new System.Drawing.Point(14, 17);
            this.grillaProductos.Margin = new System.Windows.Forms.Padding(2);
            this.grillaProductos.Name = "grillaProductos";
            this.grillaProductos.ReadOnly = true;
            this.grillaProductos.RowHeadersWidth = 51;
            this.grillaProductos.RowTemplate.Height = 24;
            this.grillaProductos.Size = new System.Drawing.Size(508, 252);
            this.grillaProductos.TabIndex = 17;
            // 
            // cod_producto
            // 
            this.cod_producto.DataPropertyName = "cod_producto";
            this.cod_producto.HeaderText = "Id";
            this.cod_producto.MinimumWidth = 6;
            this.cod_producto.Name = "cod_producto";
            this.cod_producto.ReadOnly = true;
            this.cod_producto.Visible = false;
            this.cod_producto.Width = 40;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Producto";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // PrecioxCantidad
            // 
            this.PrecioxCantidad.DataPropertyName = "precioxCantidad";
            this.PrecioxCantidad.HeaderText = "Precio X Cantidad";
            this.PrecioxCantidad.MinimumWidth = 6;
            this.PrecioxCantidad.Name = "PrecioxCantidad";
            this.PrecioxCantidad.ReadOnly = true;
            this.PrecioxCantidad.Width = 125;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "Precio x Unidad";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(385, 273);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(92, 20);
            this.txtTotal.TabIndex = 19;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(337, 271);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 20);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Total";
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
            // btnGuardarCotizacion
            // 
            this.btnGuardarCotizacion.Location = new System.Drawing.Point(335, 566);
            this.btnGuardarCotizacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarCotizacion.Name = "btnGuardarCotizacion";
            this.btnGuardarCotizacion.Size = new System.Drawing.Size(116, 27);
            this.btnGuardarCotizacion.TabIndex = 13;
            this.btnGuardarCotizacion.Text = "Registrar";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblClienteApellido);
            this.groupBox1.Controls.Add(this.lblClienteNombre);
            this.groupBox1.Controls.Add(this.lblClienteCuit);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblApellidoCliente);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(296, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 110);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // lblClienteApellido
            // 
            this.lblClienteApellido.AutoSize = true;
            this.lblClienteApellido.Location = new System.Drawing.Point(82, 25);
            this.lblClienteApellido.Name = "lblClienteApellido";
            this.lblClienteApellido.Size = new System.Drawing.Size(0, 13);
            this.lblClienteApellido.TabIndex = 26;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(456, 566);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 27);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gpVendedor
            // 
            this.gpVendedor.Controls.Add(this.lblVendedorNombre);
            this.gpVendedor.Controls.Add(this.lblVendedorDni);
            this.gpVendedor.Controls.Add(this.label7);
            this.gpVendedor.Controls.Add(this.lblVendedorNombre_);
            this.gpVendedor.Controls.Add(this.label4);
            this.gpVendedor.Controls.Add(this.cmbVendedor);
            this.gpVendedor.Location = new System.Drawing.Point(15, 76);
            this.gpVendedor.Name = "gpVendedor";
            this.gpVendedor.Size = new System.Drawing.Size(249, 110);
            this.gpVendedor.TabIndex = 29;
            this.gpVendedor.TabStop = false;
            this.gpVendedor.Text = "Vendedor";
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
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbVendedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(85, 22);
            this.cmbVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(104, 21);
            this.cmbVendedor.TabIndex = 8;
            this.cmbVendedor.SelectedIndexChanged += new System.EventHandler(this.cmbVendedor_SelectedIndexChanged);
            this.cmbVendedor.SelectionChangeCommitted += new System.EventHandler(this.cmbVendedor_SelectionChangeCommitted);
            // 
            // cbFormaDePago
            // 
            this.cbFormaDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaDePago.FormattingEnabled = true;
            this.cbFormaDePago.Location = new System.Drawing.Point(121, 557);
            this.cbFormaDePago.Name = "cbFormaDePago";
            this.cbFormaDePago.Size = new System.Drawing.Size(121, 21);
            this.cbFormaDePago.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 560);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Forma de Pago";
            // 
            // AltaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 604);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbFormaDePago);
            this.Controls.Add(this.gpVendedor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardarCotizacion);
            this.Controls.Add(this.groupBoxCotizacion);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNroCotización);
            this.Controls.Add(this.txtNroCotizacion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AltaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Cotizaciones";
            this.Load += new System.EventHandler(this.AltaCotizaciones_Load);
            this.groupBoxCotizacion.ResumeLayout(false);
            this.groupBoxCotizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpVendedor.ResumeLayout(false);
            this.gpVendedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txtNroCotizacion;
        private System.Windows.Forms.Label lblNroCotización;
        private System.Windows.Forms.GroupBox groupBoxCotizacion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grillaProductos;
        private System.Windows.Forms.Button btnGuardarCotizacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblClienteCuit;
        private System.Windows.Forms.Label lblClienteNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblProductoPrecio;
        private System.Windows.Forms.Label lblClienteApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioxCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.GroupBox gpVendedor;
        private System.Windows.Forms.Label lblVendedorNombre;
        private System.Windows.Forms.Label lblVendedorDni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblVendedorNombre_;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.ComboBox cbFormaDePago;
        private System.Windows.Forms.Label label5;
    }
}