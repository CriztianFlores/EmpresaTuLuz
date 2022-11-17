
namespace EmpresaTuLuz
{
    partial class ReporteListadoVentas
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.VENTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PROYECTODataSet = new EmpresaTuLuz.PROYECTODataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VENTASTableAdapter = new EmpresaTuLuz.PROYECTODataSetTableAdapters.VENTASTableAdapter();
            this.cbFormaDePago = new System.Windows.Forms.ComboBox();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chbFecha = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VENTASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROYECTODataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VENTASBindingSource
            // 
            this.VENTASBindingSource.DataMember = "VENTAS";
            this.VENTASBindingSource.DataSource = this.PROYECTODataSet;
            // 
            // PROYECTODataSet
            // 
            this.PROYECTODataSet.DataSetName = "PROYECTODataSet";
            this.PROYECTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DatosVendidos";
            reportDataSource3.Value = this.VENTASBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EmpresaTuLuz.listadoVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 111);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 339);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // VENTASTableAdapter
            // 
            this.VENTASTableAdapter.ClearBeforeFill = true;
            // 
            // cbFormaDePago
            // 
            this.cbFormaDePago.FormattingEnabled = true;
            this.cbFormaDePago.Location = new System.Drawing.Point(110, 29);
            this.cbFormaDePago.Name = "cbFormaDePago";
            this.cbFormaDePago.Size = new System.Drawing.Size(121, 21);
            this.cbFormaDePago.TabIndex = 1;
            this.cbFormaDePago.Text = "Todos";
            this.cbFormaDePago.SelectedIndexChanged += new System.EventHandler(this.cbModoPago_SelectedIndexChanged);
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(110, 68);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(121, 21);
            this.cmbVendedor.TabIndex = 2;
            this.cmbVendedor.Text = "Todos";
            // 
            // fechaHasta
            // 
            this.fechaHasta.Enabled = false;
            this.fechaHasta.Location = new System.Drawing.Point(56, 51);
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Size = new System.Drawing.Size(200, 20);
            this.fechaHasta.TabIndex = 3;
            // 
            // fechaDesde
            // 
            this.fechaDesde.Enabled = false;
            this.fechaDesde.Location = new System.Drawing.Point(56, 19);
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Size = new System.Drawing.Size(200, 20);
            this.fechaDesde.TabIndex = 4;
            this.fechaDesde.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbFecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fechaDesde);
            this.groupBox1.Controls.Add(this.fechaHasta);
            this.groupBox1.Location = new System.Drawing.Point(271, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 101);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Periodo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Desde";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasta";
            // 
            // chbFecha
            // 
            this.chbFecha.AutoSize = true;
            this.chbFecha.Location = new System.Drawing.Point(100, 77);
            this.chbFecha.Name = "chbFecha";
            this.chbFecha.Size = new System.Drawing.Size(84, 17);
            this.chbFecha.TabIndex = 7;
            this.chbFecha.Text = "Activar Filtro";
            this.chbFecha.UseVisualStyleBackColor = true;
            this.chbFecha.CheckedChanged += new System.EventHandler(this.chbFecha_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vendedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Forma de Pago";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Filtrar reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReporteListadoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbVendedor);
            this.Controls.Add(this.cbFormaDePago);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteListadoVentas";
            this.Text = "ReporteListadoVentas";
            this.Load += new System.EventHandler(this.ReporteListadoVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VENTASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROYECTODataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VENTASBindingSource;
        private PROYECTODataSet PROYECTODataSet;
        private PROYECTODataSetTableAdapters.VENTASTableAdapter VENTASTableAdapter;
        private System.Windows.Forms.ComboBox cbFormaDePago;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.DateTimePicker fechaHasta;
        private System.Windows.Forms.DateTimePicker fechaDesde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}