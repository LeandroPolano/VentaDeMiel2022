
namespace VentaDeMiel2022.Windows
{
    partial class FrmLocalidadAE
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
            this.LocalidadTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.ProvinciaComboBox = new System.Windows.Forms.ComboBox();
            this.CancelarIconButton = new System.Windows.Forms.Button();
            this.GuardarIconButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LocalidadTextBox
            // 
            this.LocalidadTextBox.Location = new System.Drawing.Point(121, 36);
            this.LocalidadTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LocalidadTextBox.MaxLength = 120;
            this.LocalidadTextBox.Name = "LocalidadTextBox";
            this.LocalidadTextBox.Size = new System.Drawing.Size(349, 22);
            this.LocalidadTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Localidad:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Provincia:";
            // 
            // ProvinciaComboBox
            // 
            this.ProvinciaComboBox.FormattingEnabled = true;
            this.ProvinciaComboBox.Location = new System.Drawing.Point(121, 81);
            this.ProvinciaComboBox.Name = "ProvinciaComboBox";
            this.ProvinciaComboBox.Size = new System.Drawing.Size(349, 24);
            this.ProvinciaComboBox.TabIndex = 19;
            // 
            // CancelarIconButton
            // 
            this.CancelarIconButton.Location = new System.Drawing.Point(306, 131);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(164, 57);
            this.CancelarIconButton.TabIndex = 18;
            this.CancelarIconButton.Text = "Cancelar";
            this.CancelarIconButton.UseVisualStyleBackColor = true;
            this.CancelarIconButton.Click += new System.EventHandler(this.CancelarIconButton_Click);
            // 
            // GuardarIconButton
            // 
            this.GuardarIconButton.Location = new System.Drawing.Point(34, 131);
            this.GuardarIconButton.Name = "GuardarIconButton";
            this.GuardarIconButton.Size = new System.Drawing.Size(164, 57);
            this.GuardarIconButton.TabIndex = 17;
            this.GuardarIconButton.Text = "Guardar";
            this.GuardarIconButton.UseVisualStyleBackColor = true;
            this.GuardarIconButton.Click += new System.EventHandler(this.GuardarIconButton_Click);
            // 
            // FrmLocalidadAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 231);
            this.Controls.Add(this.LocalidadTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProvinciaComboBox);
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.GuardarIconButton);
            this.Name = "FrmLocalidadAE";
            this.Text = "FrmLocalidadAE";
            this.Load += new System.EventHandler(this.FrmLocalidadAE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LocalidadTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ProvinciaComboBox;
        private System.Windows.Forms.Button CancelarIconButton;
        private System.Windows.Forms.Button GuardarIconButton;
    }
}