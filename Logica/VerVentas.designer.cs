namespace EmpresaTuLuz.Logica
{
    partial class VerVentas
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
            this.lblCotizaciones = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grillaCotizaciones = new System.Windows.Forms.DataGridView();
            this.cmbEstados = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.numCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venta_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VENTA_FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FORMA_DE_PAGO_NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCotizaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCotizaciones
            // 
            this.lblCotizaciones.AutoSize = true;
            this.lblCotizaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotizaciones.Location = new System.Drawing.Point(9, 7);
            this.lblCotizaciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCotizaciones.Name = "lblCotizaciones";
            this.lblCotizaciones.Size = new System.Drawing.Size(112, 20);
            this.lblCotizaciones.TabIndex = 0;
            this.lblCotizaciones.Text = "Cotizaciones";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.grillaCotizaciones);
            this.groupBox1.Controls.Add(this.cmbEstados);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.lblIdCliente);
            this.groupBox1.Controls.Add(this.txtVendedor);
            this.groupBox1.Controls.Add(this.lblNumero);
            this.groupBox1.Location = new System.Drawing.Point(9, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(802, 316);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(687, 29);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 26);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grillaCotizaciones
            // 
            this.grillaCotizaciones.AllowUserToAddRows = false;
            this.grillaCotizaciones.AllowUserToDeleteRows = false;
            this.grillaCotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCotizaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numCotizacion,
            this.venta_id,
            this.empleado_apellido,
            this.idCliente,
            this.idVendedor,
            this.nombreCliente,
            this.apellidoCliente,
            this.VENTA_FECHA,
            this.FORMA_DE_PAGO_NOMBRE});
            this.grillaCotizaciones.Location = new System.Drawing.Point(20, 98);
            this.grillaCotizaciones.Margin = new System.Windows.Forms.Padding(2);
            this.grillaCotizaciones.Name = "grillaCotizaciones";
            this.grillaCotizaciones.ReadOnly = true;
            this.grillaCotizaciones.RowHeadersWidth = 51;
            this.grillaCotizaciones.RowTemplate.Height = 24;
            this.grillaCotizaciones.Size = new System.Drawing.Size(755, 201);
            this.grillaCotizaciones.TabIndex = 6;
            this.grillaCotizaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaCotizaciones_CellContentClick);
            // 
            // cmbEstados
            // 
            this.cmbEstados.FormattingEnabled = true;
            this.cmbEstados.Items.AddRange(new object[] {
            "Todos"});
            this.cmbEstados.Location = new System.Drawing.Point(445, 29);
            this.cmbEstados.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(92, 21);
            this.cmbEstados.TabIndex = 5;
            this.cmbEstados.Text = "Todos";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(324, 26);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(117, 20);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Forma de pago";
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(198, 59);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(76, 20);
            this.txtCliente.TabIndex = 3;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.Location = new System.Drawing.Point(76, 57);
            this.lblIdCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(118, 20);
            this.lblIdCliente.TabIndex = 2;
            this.lblIdCliente.Text = "Apellido Cliente";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(198, 26);
            this.txtVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(76, 20);
            this.txtVendedor.TabIndex = 1;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(115, 26);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(79, 20);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Vendedor";
            this.lblNumero.Click += new System.EventHandler(this.lblNumero_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(337, 354);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(196, 26);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Ver Cotizacion Vinculada";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // numCotizacion
            // 
            this.numCotizacion.DataPropertyName = "numCotizacion";
            this.numCotizacion.HeaderText = "Numero";
            this.numCotizacion.MinimumWidth = 6;
            this.numCotizacion.Name = "numCotizacion";
            this.numCotizacion.ReadOnly = true;
            this.numCotizacion.Visible = false;
            this.numCotizacion.Width = 50;
            // 
            // venta_id
            // 
            this.venta_id.DataPropertyName = "venta_id";
            this.venta_id.HeaderText = "Numero";
            this.venta_id.Name = "venta_id";
            this.venta_id.ReadOnly = true;
            // 
            // empleado_apellido
            // 
            this.empleado_apellido.DataPropertyName = "empleado_apellido";
            this.empleado_apellido.HeaderText = "Vendedor";
            this.empleado_apellido.Name = "empleado_apellido";
            this.empleado_apellido.ReadOnly = true;
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "id_cliente";
            this.idCliente.HeaderText = "ID Cliente";
            this.idCliente.MinimumWidth = 6;
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            this.idCliente.Width = 6;
            // 
            // idVendedor
            // 
            this.idVendedor.DataPropertyName = "id_vendedor";
            this.idVendedor.HeaderText = "ID Vendedor";
            this.idVendedor.MinimumWidth = 6;
            this.idVendedor.Name = "idVendedor";
            this.idVendedor.ReadOnly = true;
            this.idVendedor.Visible = false;
            this.idVendedor.Width = 50;
            // 
            // nombreCliente
            // 
            this.nombreCliente.DataPropertyName = "nombreCliente";
            this.nombreCliente.HeaderText = "Nombre Cliente";
            this.nombreCliente.MinimumWidth = 6;
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.ReadOnly = true;
            this.nombreCliente.Width = 80;
            // 
            // apellidoCliente
            // 
            this.apellidoCliente.DataPropertyName = "apellidoCliente";
            this.apellidoCliente.HeaderText = "Apellido Cliente";
            this.apellidoCliente.MinimumWidth = 6;
            this.apellidoCliente.Name = "apellidoCliente";
            this.apellidoCliente.ReadOnly = true;
            this.apellidoCliente.Width = 80;
            // 
            // VENTA_FECHA
            // 
            this.VENTA_FECHA.DataPropertyName = "VENTA_FECHA";
            this.VENTA_FECHA.HeaderText = "Fecha";
            this.VENTA_FECHA.MinimumWidth = 6;
            this.VENTA_FECHA.Name = "VENTA_FECHA";
            this.VENTA_FECHA.ReadOnly = true;
            this.VENTA_FECHA.Width = 60;
            // 
            // FORMA_DE_PAGO_NOMBRE
            // 
            this.FORMA_DE_PAGO_NOMBRE.DataPropertyName = "FORMA_DE_PAGO_NOMBRE";
            this.FORMA_DE_PAGO_NOMBRE.HeaderText = "Forma Pago";
            this.FORMA_DE_PAGO_NOMBRE.MinimumWidth = 6;
            this.FORMA_DE_PAGO_NOMBRE.Name = "FORMA_DE_PAGO_NOMBRE";
            this.FORMA_DE_PAGO_NOMBRE.ReadOnly = true;
            this.FORMA_DE_PAGO_NOMBRE.Width = 90;
            // 
            // VerVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 391);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCotizaciones);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VerVentas";
            this.Text = "cotizacion_abm1";
            this.Load += new System.EventHandler(this.ABMC_Cotizaciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCotizaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCotizaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grillaCotizaciones;
        private System.Windows.Forms.ComboBox cmbEstados;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn venta_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn VENTA_FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FORMA_DE_PAGO_NOMBRE;
    }
}