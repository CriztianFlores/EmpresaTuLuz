namespace EmpresaTuLuz.Logica
{
    partial class ModificarUsuario
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRepetirPassword = new System.Windows.Forms.TextBox();
            this.cbEmpleadoId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.lblApellidoEmpleado = new System.Windows.Forms.Label();
            this.lblTipoDniEmpleado = new System.Windows.Forms.Label();
            this.lnlNumeroDni = new System.Windows.Forms.Label();
            this.txtEmpleadoNombre = new System.Windows.Forms.Label();
            this.txtEmpleadoApellido = new System.Windows.Forms.Label();
            this.txtEmpleadoTipoDni = new System.Windows.Forms.Label();
            this.txtEmpleadoNumeroDni = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(254, 20);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(146, 24);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Nuevo usuario";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titleLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(124, 85);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(121, 20);
            this.txtNombreUsuario.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(124, 128);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(121, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // txtRepetirPassword
            // 
            this.txtRepetirPassword.Location = new System.Drawing.Point(124, 176);
            this.txtRepetirPassword.Name = "txtRepetirPassword";
            this.txtRepetirPassword.Size = new System.Drawing.Size(121, 20);
            this.txtRepetirPassword.TabIndex = 3;
            // 
            // cbEmpleadoId
            // 
            this.cbEmpleadoId.FormattingEnabled = true;
            this.cbEmpleadoId.Location = new System.Drawing.Point(124, 227);
            this.cbEmpleadoId.Name = "cbEmpleadoId";
            this.cbEmpleadoId.Size = new System.Drawing.Size(121, 21);
            this.cbEmpleadoId.TabIndex = 4;
            this.cbEmpleadoId.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Repetir password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID empleado";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(628, 323);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(536, 323);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Empeado asociado al usuario";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(44, 46);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(50, 13);
            this.lblNombreEmpleado.TabIndex = 12;
            this.lblNombreEmpleado.Text = "Nombre: ";
            // 
            // lblApellidoEmpleado
            // 
            this.lblApellidoEmpleado.AutoSize = true;
            this.lblApellidoEmpleado.Location = new System.Drawing.Point(44, 73);
            this.lblApellidoEmpleado.Name = "lblApellidoEmpleado";
            this.lblApellidoEmpleado.Size = new System.Drawing.Size(50, 13);
            this.lblApellidoEmpleado.TabIndex = 11;
            this.lblApellidoEmpleado.Text = "Apellido: ";
            // 
            // lblTipoDniEmpleado
            // 
            this.lblTipoDniEmpleado.AutoSize = true;
            this.lblTipoDniEmpleado.Location = new System.Drawing.Point(44, 101);
            this.lblTipoDniEmpleado.Name = "lblTipoDniEmpleado";
            this.lblTipoDniEmpleado.Size = new System.Drawing.Size(56, 13);
            this.lblTipoDniEmpleado.TabIndex = 10;
            this.lblTipoDniEmpleado.Text = "Tipo DNI: ";
            // 
            // lnlNumeroDni
            // 
            this.lnlNumeroDni.AutoSize = true;
            this.lnlNumeroDni.Location = new System.Drawing.Point(44, 123);
            this.lnlNumeroDni.Name = "lnlNumeroDni";
            this.lnlNumeroDni.Size = new System.Drawing.Size(71, 13);
            this.lnlNumeroDni.TabIndex = 13;
            this.lnlNumeroDni.Text = "Numero DNi: ";
            // 
            // txtEmpleadoNombre
            // 
            this.txtEmpleadoNombre.AutoSize = true;
            this.txtEmpleadoNombre.Location = new System.Drawing.Point(100, 45);
            this.txtEmpleadoNombre.Name = "txtEmpleadoNombre";
            this.txtEmpleadoNombre.Size = new System.Drawing.Size(0, 13);
            this.txtEmpleadoNombre.TabIndex = 15;
            // 
            // txtEmpleadoApellido
            // 
            this.txtEmpleadoApellido.AutoSize = true;
            this.txtEmpleadoApellido.Location = new System.Drawing.Point(100, 73);
            this.txtEmpleadoApellido.Name = "txtEmpleadoApellido";
            this.txtEmpleadoApellido.Size = new System.Drawing.Size(0, 13);
            this.txtEmpleadoApellido.TabIndex = 14;
            // 
            // txtEmpleadoTipoDni
            // 
            this.txtEmpleadoTipoDni.AutoSize = true;
            this.txtEmpleadoTipoDni.Location = new System.Drawing.Point(100, 101);
            this.txtEmpleadoTipoDni.Name = "txtEmpleadoTipoDni";
            this.txtEmpleadoTipoDni.Size = new System.Drawing.Size(0, 13);
            this.txtEmpleadoTipoDni.TabIndex = 13;
            // 
            // txtEmpleadoNumeroDni
            // 
            this.txtEmpleadoNumeroDni.AutoSize = true;
            this.txtEmpleadoNumeroDni.Location = new System.Drawing.Point(121, 123);
            this.txtEmpleadoNumeroDni.Name = "txtEmpleadoNumeroDni";
            this.txtEmpleadoNumeroDni.Size = new System.Drawing.Size(0, 13);
            this.txtEmpleadoNumeroDni.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtEmpleadoNumeroDni);
            this.panel1.Controls.Add(this.txtEmpleadoTipoDni);
            this.panel1.Controls.Add(this.txtEmpleadoApellido);
            this.panel1.Controls.Add(this.txtEmpleadoNombre);
            this.panel1.Controls.Add(this.lnlNumeroDni);
            this.panel1.Controls.Add(this.lblTipoDniEmpleado);
            this.panel1.Controls.Add(this.lblApellidoEmpleado);
            this.panel1.Controls.Add(this.lblNombreEmpleado);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(374, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 175);
            this.panel1.TabIndex = 9;
            // 
            // ModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 358);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEmpleadoId);
            this.Controls.Add(this.txtRepetirPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.titleLbl);
            this.Name = "ModificarUsuario";
            this.Text = "ModificarUsuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRepetirPassword;
        private System.Windows.Forms.ComboBox cbEmpleadoId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Label lblApellidoEmpleado;
        private System.Windows.Forms.Label lblTipoDniEmpleado;
        private System.Windows.Forms.Label lnlNumeroDni;
        private System.Windows.Forms.Label txtEmpleadoNombre;
        private System.Windows.Forms.Label txtEmpleadoApellido;
        private System.Windows.Forms.Label txtEmpleadoTipoDni;
        private System.Windows.Forms.Label txtEmpleadoNumeroDni;
        private System.Windows.Forms.Panel panel1;
    }
}