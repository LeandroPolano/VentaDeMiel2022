
namespace VentaDeMiel2022.Windows
{
    partial class FrmProvinciaAE
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
            this.PaisTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CancelarIconButton = new System.Windows.Forms.Button();
            this.GuardarIconButton = new System.Windows.Forms.Button();
            this.PaisComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PaisTextBox
            // 
            this.PaisTextBox.Location = new System.Drawing.Point(118, 42);
            this.PaisTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PaisTextBox.MaxLength = 120;
            this.PaisTextBox.Name = "PaisTextBox";
            this.PaisTextBox.Size = new System.Drawing.Size(349, 22);
            this.PaisTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Provincia:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CancelarIconButton
            // 
            this.CancelarIconButton.Location = new System.Drawing.Point(282, 182);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(164, 57);
            this.CancelarIconButton.TabIndex = 12;
            this.CancelarIconButton.Text = "Cancelar";
            this.CancelarIconButton.UseVisualStyleBackColor = true;
            this.CancelarIconButton.Click += new System.EventHandler(this.CancelarIconButton_Click);
            // 
            // GuardarIconButton
            // 
            this.GuardarIconButton.Location = new System.Drawing.Point(46, 182);
            this.GuardarIconButton.Name = "GuardarIconButton";
            this.GuardarIconButton.Size = new System.Drawing.Size(164, 57);
            this.GuardarIconButton.TabIndex = 11;
            this.GuardarIconButton.Text = "Guardar";
            this.GuardarIconButton.UseVisualStyleBackColor = true;
            this.GuardarIconButton.Click += new System.EventHandler(this.GuardarIconButton_Click);
            // 
            // PaisComboBox
            // 
            this.PaisComboBox.FormattingEnabled = true;
            this.PaisComboBox.Location = new System.Drawing.Point(118, 91);
            this.PaisComboBox.Name = "PaisComboBox";
            this.PaisComboBox.Size = new System.Drawing.Size(349, 24);
            this.PaisComboBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pais:";
            // 
            // FrmProvinciaAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 272);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PaisComboBox);
            this.Controls.Add(this.PaisTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.GuardarIconButton);
            this.Name = "FrmProvinciaAE";
            this.Text = "FrmProvinciaAE";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PaisTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button CancelarIconButton;
        private System.Windows.Forms.Button GuardarIconButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PaisComboBox;
    }
}