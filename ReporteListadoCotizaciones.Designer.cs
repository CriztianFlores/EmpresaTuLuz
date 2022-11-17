
namespace EmpresaTuLuz
{
    partial class ReporteListadoCotizaciones
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.COTIZACIONESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PROYECTODataSet = new EmpresaTuLuz.PROYECTODataSet();
            this.rvCotizaciones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.COTIZACIONESTableAdapter = new EmpresaTuLuz.PROYECTODataSetTableAdapters.COTIZACIONESTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.precioMinimo = new System.Windows.Forms.NumericUpDown();
            this.precioMaximo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chbPrecio = new System.Windows.Forms.CheckBox();
            this.chbPeriodo = new System.Windows.Forms.CheckBox();
            this.cmbEstados = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.COTIZACIONESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROYECTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioMaximo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // COTIZACIONESBindingSource
            // 
            this.COTIZACIONESBindingSource.DataMember = "COTIZACIONES";
            this.COTIZACIONESBindingSource.DataSource = this.PROYECTODataSet;
            // 
            // PROYECTODataSet
            // 
            this.PROYECTODataSet.DataSetName = "PROYECTODataSet";
            this.PROYECTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvCotizaciones
            // 
            this.rvCotizaciones.AutoSize = true;
            reportDataSource4.Name = "cotizacionesDetalladas";
            reportDataSource4.Value = this.COTIZACIONESBindingSource;
            this.rvCotizaciones.LocalReport.DataSources.Add(reportDataSource4);
            this.rvCotizaciones.LocalReport.ReportEmbeddedResource = "EmpresaTuLuz.listadoCotizaciones.rdlc";
            this.rvCotizaciones.Location = new System.Drawing.Point(1, 124);
            this.rvCotizaciones.Name = "rvCotizaciones";
            this.rvCotizaciones.ServerReport.BearerToken = null;
            this.rvCotizaciones.Size = new System.Drawing.Size(881, 438);
            this.rvCotizaciones.TabIndex = 0;
            this.rvCotizaciones.Load += new System.EventHandler(this.rvCotizaciones_Load);
            // 
            // COTIZACIONESTableAdapter
            // 
            this.COTIZACIONESTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(712, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Filtrar reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fechaDesde
            // 
            this.fechaDesde.Enabled = false;
            this.fechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDesde.Location = new System.Drawing.Point(67, 25);
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Size = new System.Drawing.Size(200, 20);
            this.fechaDesde.TabIndex = 2;
            // 
            // fechaHasta
            // 
            this.fechaHasta.Enabled = false;
            this.fechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaHasta.Location = new System.Drawing.Point(67, 51);
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Size = new System.Drawing.Size(200, 20);
            this.fechaHasta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // precioMinimo
            // 
            this.precioMinimo.Enabled = false;
            this.precioMinimo.Location = new System.Drawing.Point(74, 21);
            this.precioMinimo.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.precioMinimo.Name = "precioMinimo";
            this.precioMinimo.Size = new System.Drawing.Size(120, 20);
            this.precioMinimo.TabIndex = 7;
            // 
            // precioMaximo
            // 
            this.precioMaximo.Enabled = false;
            this.precioMaximo.Location = new System.Drawing.Point(74, 45);
            this.precioMaximo.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.precioMaximo.Name = "precioMaximo";
            this.precioMaximo.Size = new System.Drawing.Size(120, 20);
            this.precioMaximo.TabIndex = 8;
            this.precioMaximo.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Minimo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Maximo";
            // 
            // chbPrecio
            // 
            this.chbPrecio.AutoSize = true;
            this.chbPrecio.Location = new System.Drawing.Point(64, 77);
            this.chbPrecio.Name = "chbPrecio";
            this.chbPrecio.Size = new System.Drawing.Size(84, 17);
            this.chbPrecio.TabIndex = 12;
            this.chbPrecio.Text = "Activar Flitro";
            this.chbPrecio.UseVisualStyleBackColor = true;
            this.chbPrecio.CheckedChanged += new System.EventHandler(this.chbPrecio_CheckedChanged);
            // 
            // chbPeriodo
            // 
            this.chbPeriodo.AutoSize = true;
            this.chbPeriodo.Location = new System.Drawing.Point(120, 77);
            this.chbPeriodo.Name = "chbPeriodo";
            this.chbPeriodo.Size = new System.Drawing.Size(87, 17);
            this.chbPeriodo.TabIndex = 13;
            this.chbPeriodo.Text = "Activar  Filtro";
            this.chbPeriodo.UseVisualStyleBackColor = true;
            this.chbPeriodo.CheckedChanged += new System.EventHandler(this.chbPeriodo_CheckedChanged);
            // 
            // cmbEstados
            // 
            this.cmbEstados.FormattingEnabled = true;
            this.cmbEstados.Location = new System.Drawing.Point(71, 50);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(121, 21);
            this.cmbEstados.TabIndex = 14;
            this.cmbEstados.Text = "Todos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Estado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.precioMinimo);
            this.groupBox1.Controls.Add(this.precioMaximo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chbPrecio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(220, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 106);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precio Total";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fechaDesde);
            this.groupBox2.Controls.Add(this.fechaHasta);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.chbPeriodo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(426, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 106);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Periodo";
            // 
            // ReporteListadoCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(894, 574);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbEstados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rvCotizaciones);
            this.Name = "ReporteListadoCotizaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de cotizaciones";
            this.Load += new System.EventHandler(this.ReporteListadoCotizaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.COTIZACIONESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROYECTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioMaximo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvCotizaciones;
        private System.Windows.Forms.BindingSource COTIZACIONESBindingSource;
        private PROYECTODataSet PROYECTODataSet;
        private PROYECTODataSetTableAdapters.COTIZACIONESTableAdapter COTIZACIONESTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker fechaDesde;
        private System.Windows.Forms.DateTimePicker fechaHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown precioMinimo;
        private System.Windows.Forms.NumericUpDown precioMaximo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbPrecio;
        private System.Windows.Forms.CheckBox chbPeriodo;
        private System.Windows.Forms.ComboBox cmbEstados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}