
namespace EmpresaTuLuz
{
    partial class ReporteEstadisticaVentas
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
            this.rvEstadisticaVentaProducto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFormaDePago = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.Producto = new System.Windows.Forms.Label();
            this.cbAño = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rvEstadisticaVentaProducto
            // 
            this.rvEstadisticaVentaProducto.LocalReport.ReportEmbeddedResource = "EmpresaTuLuz.EstadisticaProducto.rdlc";
            this.rvEstadisticaVentaProducto.Location = new System.Drawing.Point(24, 87);
            this.rvEstadisticaVentaProducto.Name = "rvEstadisticaVentaProducto";
            this.rvEstadisticaVentaProducto.ServerReport.BearerToken = null;
            this.rvEstadisticaVentaProducto.Size = new System.Drawing.Size(918, 763);
            this.rvEstadisticaVentaProducto.TabIndex = 0;
            this.rvEstadisticaVentaProducto.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(40, 33);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(121, 21);
            this.cmbVendedor.TabIndex = 1;
            this.cmbVendedor.Text = "Todos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Empleado";
            // 
            // cbFormaDePago
            // 
            this.cbFormaDePago.FormattingEnabled = true;
            this.cbFormaDePago.Location = new System.Drawing.Point(196, 33);
            this.cbFormaDePago.Name = "cbFormaDePago";
            this.cbFormaDePago.Size = new System.Drawing.Size(121, 21);
            this.cbFormaDePago.TabIndex = 3;
            this.cbFormaDePago.Text = "Todos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modo de pago";
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(348, 33);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(121, 21);
            this.cbProducto.TabIndex = 5;
            this.cbProducto.Text = "Todos";
            // 
            // Producto
            // 
            this.Producto.AutoSize = true;
            this.Producto.Location = new System.Drawing.Point(384, 17);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(50, 13);
            this.Producto.TabIndex = 6;
            this.Producto.Text = "Producto";
            // 
            // cbAño
            // 
            this.cbAño.FormattingEnabled = true;
            this.cbAño.Location = new System.Drawing.Point(499, 33);
            this.cbAño.Name = "cbAño";
            this.cbAño.Size = new System.Drawing.Size(121, 21);
            this.cbAño.TabIndex = 7;
            this.cbAño.Text = "2022";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Año";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(654, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Generar grafico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReporteEstadisticaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 876);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbAño);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFormaDePago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVendedor);
            this.Controls.Add(this.rvEstadisticaVentaProducto);
            this.Name = "ReporteEstadisticaVentas";
            this.Text = "Estadistica Ventas de Producto";
            this.Load += new System.EventHandler(this.ReporteEstadisticaVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvEstadisticaVentaProducto;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFormaDePago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.Label Producto;
        private System.Windows.Forms.ComboBox cbAño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}