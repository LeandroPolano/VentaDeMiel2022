
namespace VentaDeMiel2022.Windows
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.ClienteButton = new System.Windows.Forms.Button();
            this.LocalidadButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.ProvinciaButton = new System.Windows.Forms.Button();
            this.TipoEnvaseButton = new System.Windows.Forms.Button();
            this.PaisButton = new System.Windows.Forms.Button();
            this.ClientesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CerrarButton);
            this.splitContainer1.Panel2.Controls.Add(this.ClienteButton);
            this.splitContainer1.Panel2.Controls.Add(this.LocalidadButton);
            this.splitContainer1.Panel2.Controls.Add(this.button6);
            this.splitContainer1.Panel2.Controls.Add(this.ProvinciaButton);
            this.splitContainer1.Panel2.Controls.Add(this.TipoEnvaseButton);
            this.splitContainer1.Panel2.Controls.Add(this.PaisButton);
            this.splitContainer1.Panel2.Controls.Add(this.ClientesButton);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(683, 506);
            this.splitContainer1.SplitterDistance = 66;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venta De Miel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CerrarButton
            // 
            this.CerrarButton.BackColor = System.Drawing.Color.Maroon;
            this.CerrarButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CerrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CerrarButton.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CerrarButton.Location = new System.Drawing.Point(510, 336);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(161, 55);
            this.CerrarButton.TabIndex = 7;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = false;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // ClienteButton
            // 
            this.ClienteButton.Font = new System.Drawing.Font("Open Sans", 10.2F);
            this.ClienteButton.Location = new System.Drawing.Point(63, 236);
            this.ClienteButton.Name = "ClienteButton";
            this.ClienteButton.Size = new System.Drawing.Size(161, 55);
            this.ClienteButton.TabIndex = 6;
            this.ClienteButton.Text = "Cliente";
            this.ClienteButton.UseVisualStyleBackColor = true;
            this.ClienteButton.Click += new System.EventHandler(this.ClienteButton_Click);
            // 
            // LocalidadButton
            // 
            this.LocalidadButton.Font = new System.Drawing.Font("Open Sans", 10.2F);
            this.LocalidadButton.Location = new System.Drawing.Point(452, 144);
            this.LocalidadButton.Name = "LocalidadButton";
            this.LocalidadButton.Size = new System.Drawing.Size(161, 68);
            this.LocalidadButton.TabIndex = 5;
            this.LocalidadButton.Text = "Localidades";
            this.LocalidadButton.UseVisualStyleBackColor = true;
            this.LocalidadButton.Click += new System.EventHandler(this.LocalidadButton_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Open Sans", 10.2F);
            this.button6.Location = new System.Drawing.Point(258, 144);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(161, 68);
            this.button6.TabIndex = 4;
            this.button6.Text = "Tipo De Documento";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ProvinciaButton
            // 
            this.ProvinciaButton.Font = new System.Drawing.Font("Open Sans", 10.2F);
            this.ProvinciaButton.Location = new System.Drawing.Point(64, 144);
            this.ProvinciaButton.Name = "ProvinciaButton";
            this.ProvinciaButton.Size = new System.Drawing.Size(161, 68);
            this.ProvinciaButton.TabIndex = 3;
            this.ProvinciaButton.Text = "Provincia";
            this.ProvinciaButton.UseVisualStyleBackColor = true;
            this.ProvinciaButton.Click += new System.EventHandler(this.ProvinciaButton_Click);
            // 
            // TipoEnvaseButton
            // 
            this.TipoEnvaseButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.TipoEnvaseButton.Font = new System.Drawing.Font("Open Sans", 10.2F);
            this.TipoEnvaseButton.Location = new System.Drawing.Point(452, 51);
            this.TipoEnvaseButton.Name = "TipoEnvaseButton";
            this.TipoEnvaseButton.Size = new System.Drawing.Size(161, 55);
            this.TipoEnvaseButton.TabIndex = 2;
            this.TipoEnvaseButton.Text = "Tipo De Envase";
            this.TipoEnvaseButton.UseVisualStyleBackColor = false;
            this.TipoEnvaseButton.Click += new System.EventHandler(this.TipoEnvaseButton_Click);
            // 
            // PaisButton
            // 
            this.PaisButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.PaisButton.Font = new System.Drawing.Font("Open Sans", 10.2F);
            this.PaisButton.Location = new System.Drawing.Point(257, 51);
            this.PaisButton.Name = "PaisButton";
            this.PaisButton.Size = new System.Drawing.Size(161, 55);
            this.PaisButton.TabIndex = 1;
            this.PaisButton.Text = "Pais";
            this.PaisButton.UseVisualStyleBackColor = false;
            this.PaisButton.Click += new System.EventHandler(this.PaisButton_Click);
            // 
            // ClientesButton
            // 
            this.ClientesButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientesButton.Font = new System.Drawing.Font("Open Sans", 10.2F);
            this.ClientesButton.Location = new System.Drawing.Point(63, 51);
            this.ClientesButton.Name = "ClientesButton";
            this.ClientesButton.Size = new System.Drawing.Size(161, 55);
            this.ClientesButton.TabIndex = 0;
            this.ClientesButton.Text = "Clientes";
            this.ClientesButton.UseVisualStyleBackColor = false;
            this.ClientesButton.Click += new System.EventHandler(this.ClientesButton_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 506);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(701, 553);
            this.MinimumSize = new System.Drawing.Size(701, 553);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClienteButton;
        private System.Windows.Forms.Button LocalidadButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button ProvinciaButton;
        private System.Windows.Forms.Button TipoEnvaseButton;
        private System.Windows.Forms.Button PaisButton;
        private System.Windows.Forms.Button ClientesButton;
        private System.Windows.Forms.Button CerrarButton;
    }
}

