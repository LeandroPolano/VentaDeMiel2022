
namespace VentaDeMiel2022.Windows
{
    partial class FrmClienteAE
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
            this.NroDocumentoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.TipoDeDocumentoComboBox = new System.Windows.Forms.ComboBox();
            this.CancelarIconButton = new System.Windows.Forms.Button();
            this.GuardarIconButton = new System.Windows.Forms.Button();
            this.ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PaisComboBox = new System.Windows.Forms.ComboBox();
            this.CorreoElectronicoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ProvinciaComboBox = new System.Windows.Forms.ComboBox();
            this.TelefonoFijoTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LocalidadComboBox = new System.Windows.Forms.ComboBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TelefonoMovilTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // NroDocumentoTextBox
            // 
            this.NroDocumentoTextBox.Location = new System.Drawing.Point(225, 118);
            this.NroDocumentoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NroDocumentoTextBox.MaxLength = 120;
            this.NroDocumentoTextBox.Name = "NroDocumentoTextBox";
            this.NroDocumentoTextBox.Size = new System.Drawing.Size(308, 22);
            this.NroDocumentoTextBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nro Documento";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tipo De Documento";
            // 
            // TipoDeDocumentoComboBox
            // 
            this.TipoDeDocumentoComboBox.FormattingEnabled = true;
            this.TipoDeDocumentoComboBox.Location = new System.Drawing.Point(256, 87);
            this.TipoDeDocumentoComboBox.Name = "TipoDeDocumentoComboBox";
            this.TipoDeDocumentoComboBox.Size = new System.Drawing.Size(277, 24);
            this.TipoDeDocumentoComboBox.TabIndex = 25;
            // 
            // CancelarIconButton
            // 
            this.CancelarIconButton.Location = new System.Drawing.Point(694, 291);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(164, 57);
            this.CancelarIconButton.TabIndex = 24;
            this.CancelarIconButton.Text = "Cancelar";
            this.CancelarIconButton.UseVisualStyleBackColor = true;
            this.CancelarIconButton.Click += new System.EventHandler(this.CancelarIconButton_Click);
            // 
            // GuardarIconButton
            // 
            this.GuardarIconButton.Location = new System.Drawing.Point(694, 28);
            this.GuardarIconButton.Name = "GuardarIconButton";
            this.GuardarIconButton.Size = new System.Drawing.Size(164, 57);
            this.GuardarIconButton.TabIndex = 23;
            this.GuardarIconButton.Text = "Guardar";
            this.GuardarIconButton.UseVisualStyleBackColor = true;
            this.GuardarIconButton.Click += new System.EventHandler(this.GuardarIconButton_Click);
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Location = new System.Drawing.Point(184, 58);
            this.ApellidoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ApellidoTextBox.MaxLength = 120;
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(349, 22);
            this.ApellidoTextBox.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 237);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Pais";
            // 
            // PaisComboBox
            // 
            this.PaisComboBox.FormattingEnabled = true;
            this.PaisComboBox.Location = new System.Drawing.Point(184, 237);
            this.PaisComboBox.Name = "PaisComboBox";
            this.PaisComboBox.Size = new System.Drawing.Size(349, 24);
            this.PaisComboBox.TabIndex = 29;
            // 
            // CorreoElectronicoTextBox
            // 
            this.CorreoElectronicoTextBox.Location = new System.Drawing.Point(244, 328);
            this.CorreoElectronicoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CorreoElectronicoTextBox.MaxLength = 120;
            this.CorreoElectronicoTextBox.Name = "CorreoElectronicoTextBox";
            this.CorreoElectronicoTextBox.Size = new System.Drawing.Size(289, 22);
            this.CorreoElectronicoTextBox.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 328);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Correo Electronico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 268);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Telefono Fijo";
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Location = new System.Drawing.Point(184, 148);
            this.DireccionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DireccionTextBox.MaxLength = 120;
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(349, 22);
            this.DireccionTextBox.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(93, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Direccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(95, 207);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Provincia";
            // 
            // ProvinciaComboBox
            // 
            this.ProvinciaComboBox.FormattingEnabled = true;
            this.ProvinciaComboBox.Location = new System.Drawing.Point(184, 207);
            this.ProvinciaComboBox.Name = "ProvinciaComboBox";
            this.ProvinciaComboBox.Size = new System.Drawing.Size(349, 24);
            this.ProvinciaComboBox.TabIndex = 37;
            // 
            // TelefonoFijoTextBox
            // 
            this.TelefonoFijoTextBox.Location = new System.Drawing.Point(203, 268);
            this.TelefonoFijoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TelefonoFijoTextBox.MaxLength = 120;
            this.TelefonoFijoTextBox.Name = "TelefonoFijoTextBox";
            this.TelefonoFijoTextBox.Size = new System.Drawing.Size(330, 22);
            this.TelefonoFijoTextBox.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(90, 177);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Localidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(93, 298);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Telefono Movil";
            // 
            // LocalidadComboBox
            // 
            this.LocalidadComboBox.FormattingEnabled = true;
            this.LocalidadComboBox.Location = new System.Drawing.Point(184, 177);
            this.LocalidadComboBox.Name = "LocalidadComboBox";
            this.LocalidadComboBox.Size = new System.Drawing.Size(349, 24);
            this.LocalidadComboBox.TabIndex = 41;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(184, 28);
            this.NombreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NombreTextBox.MaxLength = 120;
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(349, 22);
            this.NombreTextBox.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(90, 28);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Nombre";
            // 
            // TelefonoMovilTextBox
            // 
            this.TelefonoMovilTextBox.Location = new System.Drawing.Point(218, 298);
            this.TelefonoMovilTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TelefonoMovilTextBox.MaxLength = 120;
            this.TelefonoMovilTextBox.Name = "TelefonoMovilTextBox";
            this.TelefonoMovilTextBox.Size = new System.Drawing.Size(315, 22);
            this.TelefonoMovilTextBox.TabIndex = 45;
            // 
            // FrmClienteAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 558);
            this.Controls.Add(this.TelefonoMovilTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.TelefonoFijoTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LocalidadComboBox);
            this.Controls.Add(this.DireccionTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ProvinciaComboBox);
            this.Controls.Add(this.CorreoElectronicoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ApellidoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PaisComboBox);
            this.Controls.Add(this.NroDocumentoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TipoDeDocumentoComboBox);
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.GuardarIconButton);
            this.Name = "FrmClienteAE";
            this.Text = "FrmClienteAE";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NroDocumentoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox TelefonoMovilTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox TelefonoFijoTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox LocalidadComboBox;
        private System.Windows.Forms.TextBox DireccionTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ProvinciaComboBox;
        private System.Windows.Forms.TextBox CorreoElectronicoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ApellidoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PaisComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TipoDeDocumentoComboBox;
        private System.Windows.Forms.Button CancelarIconButton;
        private System.Windows.Forms.Button GuardarIconButton;
    }
}