
namespace VentaDeMiel2022.Windows
{
    partial class FrmProvincia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NuevoIconButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.EditarIconButton = new System.Windows.Forms.Button();
            this.BorrarIconButton = new System.Windows.Forms.Button();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NuevoIconButton
            // 
            this.NuevoIconButton.Location = new System.Drawing.Point(12, 12);
            this.NuevoIconButton.Name = "NuevoIconButton";
            this.NuevoIconButton.Size = new System.Drawing.Size(83, 57);
            this.NuevoIconButton.TabIndex = 0;
            this.NuevoIconButton.Text = "Nuevo";
            this.NuevoIconButton.UseVisualStyleBackColor = true;
            this.NuevoIconButton.Click += new System.EventHandler(this.NuevoIconButton_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.CerrarButton);
            this.splitContainer1.Panel1.Controls.Add(this.EditarIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.BorrarIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.NuevoIconButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DatosDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 79;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 4;
            // 
            // CerrarButton
            // 
            this.CerrarButton.Location = new System.Drawing.Point(705, 12);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(83, 57);
            this.CerrarButton.TabIndex = 3;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = true;
            // 
            // EditarIconButton
            // 
            this.EditarIconButton.Location = new System.Drawing.Point(190, 12);
            this.EditarIconButton.Name = "EditarIconButton";
            this.EditarIconButton.Size = new System.Drawing.Size(83, 57);
            this.EditarIconButton.TabIndex = 2;
            this.EditarIconButton.Text = "Editar";
            this.EditarIconButton.UseVisualStyleBackColor = true;
            // 
            // BorrarIconButton
            // 
            this.BorrarIconButton.Location = new System.Drawing.Point(101, 12);
            this.BorrarIconButton.Name = "BorrarIconButton";
            this.BorrarIconButton.Size = new System.Drawing.Size(83, 57);
            this.BorrarIconButton.TabIndex = 1;
            this.BorrarIconButton.Text = "Borrar";
            this.BorrarIconButton.UseVisualStyleBackColor = true;
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DatosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProvincia,
            this.colPais});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.RowHeadersWidth = 51;
            this.DatosDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosDataGridView.RowTemplate.Height = 28;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(800, 366);
            this.DatosDataGridView.TabIndex = 0;
            // 
            // colProvincia
            // 
            this.colProvincia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProvincia.HeaderText = "Provincia";
            this.colProvincia.MinimumWidth = 6;
            this.colProvincia.Name = "colProvincia";
            this.colProvincia.ReadOnly = true;
            this.colProvincia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPais
            // 
            this.colPais.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPais.HeaderText = "Pais";
            this.colPais.MinimumWidth = 6;
            this.colPais.Name = "colPais";
            this.colPais.ReadOnly = true;
            this.colPais.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmProvincia";
            this.Text = "FrmProvincia";
            this.Load += new System.EventHandler(this.FrmProvincia_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NuevoIconButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button CerrarButton;
        private System.Windows.Forms.Button EditarIconButton;
        private System.Windows.Forms.Button BorrarIconButton;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPais;
    }
}