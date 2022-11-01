namespace EmpresaTuLuz.Logica
{
    partial class ABMC_Cotizaciones
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
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.numCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivo_perdida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox1.Controls.Add(this.txtIdCliente);
            this.groupBox1.Controls.Add(this.lblIdCliente);
            this.groupBox1.Controls.Add(this.txtNumero);
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
            this.empleado_apellido,
            this.idCliente,
            this.idVendedor,
            this.nombreCliente,
            this.apellidoCliente,
            this.fecha,
            this.observaciones,
            this.precioTotal,
            this.estado,
            this.motivo_perdida,
            this.id_estado});
            this.grillaCotizaciones.Location = new System.Drawing.Point(20, 98);
            this.grillaCotizaciones.Margin = new System.Windows.Forms.Padding(2);
            this.grillaCotizaciones.Name = "grillaCotizaciones";
            this.grillaCotizaciones.ReadOnly = true;
            this.grillaCotizaciones.RowHeadersWidth = 51;
            this.grillaCotizaciones.RowTemplate.Height = 24;
            this.grillaCotizaciones.Size = new System.Drawing.Size(755, 201);
            this.grillaCotizaciones.TabIndex = 6;
            // 
            // cmbEstados
            // 
            this.cmbEstados.FormattingEnabled = true;
            this.cmbEstados.Location = new System.Drawing.Point(388, 23);
            this.cmbEstados.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(92, 21);
            this.cmbEstados.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(324, 26);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(198, 59);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(76, 20);
            this.txtIdCliente.TabIndex = 3;
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
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(198, 26);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(76, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(129, 24);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(65, 20);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(628, 350);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(76, 26);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(708, 350);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(76, 26);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // numCotizacion
            // 
            this.numCotizacion.DataPropertyName = "numCotizacion";
            this.numCotizacion.HeaderText = "Numero";
            this.numCotizacion.MinimumWidth = 6;
            this.numCotizacion.Name = "numCotizacion";
            this.numCotizacion.ReadOnly = true;
            this.numCotizacion.Width = 50;
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
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 60;
            // 
            // observaciones
            // 
            this.observaciones.DataPropertyName = "observaciones";
            this.observaciones.HeaderText = "Observaciones";
            this.observaciones.MinimumWidth = 6;
            this.observaciones.Name = "observaciones";
            this.observaciones.ReadOnly = true;
            this.observaciones.Width = 80;
            // 
            // precioTotal
            // 
            this.precioTotal.DataPropertyName = "precioTotal";
            this.precioTotal.HeaderText = "Precio Total";
            this.precioTotal.MinimumWidth = 6;
            this.precioTotal.Name = "precioTotal";
            this.precioTotal.ReadOnly = true;
            this.precioTotal.Width = 80;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 90;
            // 
            // motivo_perdida
            // 
            this.motivo_perdida.DataPropertyName = "motivo_perdida";
            this.motivo_perdida.HeaderText = "Motivo Perdida";
            this.motivo_perdida.MinimumWidth = 6;
            this.motivo_perdida.Name = "motivo_perdida";
            this.motivo_perdida.ReadOnly = true;
            this.motivo_perdida.Width = 80;
            // 
            // id_estado
            // 
            this.id_estado.DataPropertyName = "id_estado";
            this.id_estado.HeaderText = "id_estado";
            this.id_estado.Name = "id_estado";
            this.id_estado.ReadOnly = true;
            this.id_estado.Visible = false;
            this.id_estado.Width = 5;
            // 
            // ABMC_Cotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 391);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCotizaciones);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ABMC_Cotizaciones";
            this.Text = "ABMC_Cotizaciones";
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
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivo_perdida;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_estado;
    }
}