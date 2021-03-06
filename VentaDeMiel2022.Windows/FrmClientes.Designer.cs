
namespace VentaDeMiel2022.Windows
{
    partial class FrmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.colCorreoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefonoFijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoDeDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioDescIconButton = new FontAwesome.Sharp.IconButton();
            this.OredenarAZPorProductoiconButton = new FontAwesome.Sharp.IconButton();
            this.FiltrariconButton = new FontAwesome.Sharp.IconButton();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.EditarIconButton = new System.Windows.Forms.Button();
            this.BorrarIconButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.NuevoIconButton = new System.Windows.Forms.Button();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colTelefonoMovil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // colCorreoElectronico
            // 
            this.colCorreoElectronico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCorreoElectronico.HeaderText = "Correo Electronico";
            this.colCorreoElectronico.MinimumWidth = 6;
            this.colCorreoElectronico.Name = "colCorreoElectronico";
            this.colCorreoElectronico.ReadOnly = true;
            this.colCorreoElectronico.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTelefonoFijo
            // 
            this.colTelefonoFijo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTelefonoFijo.HeaderText = "Telefono Fijo";
            this.colTelefonoFijo.MinimumWidth = 6;
            this.colTelefonoFijo.Name = "colTelefonoFijo";
            this.colTelefonoFijo.ReadOnly = true;
            this.colTelefonoFijo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // colProvincia
            // 
            this.colProvincia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProvincia.HeaderText = "Provincia";
            this.colProvincia.MinimumWidth = 6;
            this.colProvincia.Name = "colProvincia";
            this.colProvincia.ReadOnly = true;
            this.colProvincia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colLocalidad
            // 
            this.colLocalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLocalidad.HeaderText = "Localidad";
            this.colLocalidad.MinimumWidth = 6;
            this.colLocalidad.Name = "colLocalidad";
            this.colLocalidad.ReadOnly = true;
            this.colLocalidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDireccion
            // 
            this.colDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDireccion.HeaderText = "Direccion";
            this.colDireccion.MinimumWidth = 6;
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.ReadOnly = true;
            this.colDireccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colNroDocumento
            // 
            this.colNroDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNroDocumento.HeaderText = "Numero de documento";
            this.colNroDocumento.MinimumWidth = 6;
            this.colNroDocumento.Name = "colNroDocumento";
            this.colNroDocumento.ReadOnly = true;
            this.colNroDocumento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTipoDeDocumento
            // 
            this.colTipoDeDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTipoDeDocumento.HeaderText = "TipoDeDocumento";
            this.colTipoDeDocumento.MinimumWidth = 6;
            this.colTipoDeDocumento.Name = "colTipoDeDocumento";
            this.colTipoDeDocumento.ReadOnly = true;
            this.colTipoDeDocumento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colApellido
            // 
            this.colApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.MinimumWidth = 6;
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            this.colApellido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PrecioDescIconButton
            // 
            this.PrecioDescIconButton.BackColor = System.Drawing.Color.Transparent;
            this.PrecioDescIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrecioDescIconButton.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDown;
            this.PrecioDescIconButton.IconColor = System.Drawing.Color.DodgerBlue;
            this.PrecioDescIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PrecioDescIconButton.Location = new System.Drawing.Point(485, 12);
            this.PrecioDescIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.PrecioDescIconButton.Name = "PrecioDescIconButton";
            this.PrecioDescIconButton.Size = new System.Drawing.Size(93, 71);
            this.PrecioDescIconButton.TabIndex = 11;
            this.PrecioDescIconButton.Text = "Z-A";
            this.PrecioDescIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PrecioDescIconButton.UseVisualStyleBackColor = false;
            // 
            // OredenarAZPorProductoiconButton
            // 
            this.OredenarAZPorProductoiconButton.BackColor = System.Drawing.Color.Transparent;
            this.OredenarAZPorProductoiconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OredenarAZPorProductoiconButton.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDown;
            this.OredenarAZPorProductoiconButton.IconColor = System.Drawing.Color.DodgerBlue;
            this.OredenarAZPorProductoiconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OredenarAZPorProductoiconButton.Location = new System.Drawing.Point(384, 12);
            this.OredenarAZPorProductoiconButton.Margin = new System.Windows.Forms.Padding(4);
            this.OredenarAZPorProductoiconButton.Name = "OredenarAZPorProductoiconButton";
            this.OredenarAZPorProductoiconButton.Size = new System.Drawing.Size(93, 71);
            this.OredenarAZPorProductoiconButton.TabIndex = 14;
            this.OredenarAZPorProductoiconButton.Text = "A-Z";
            this.OredenarAZPorProductoiconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OredenarAZPorProductoiconButton.UseVisualStyleBackColor = false;
            // 
            // FiltrariconButton
            // 
            this.FiltrariconButton.BackColor = System.Drawing.Color.Transparent;
            this.FiltrariconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiltrariconButton.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.FiltrariconButton.IconColor = System.Drawing.Color.Blue;
            this.FiltrariconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FiltrariconButton.Location = new System.Drawing.Point(272, 11);
            this.FiltrariconButton.Margin = new System.Windows.Forms.Padding(4);
            this.FiltrariconButton.Name = "FiltrariconButton";
            this.FiltrariconButton.Size = new System.Drawing.Size(104, 72);
            this.FiltrariconButton.TabIndex = 10;
            this.FiltrariconButton.Text = "Filtrar";
            this.FiltrariconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FiltrariconButton.UseVisualStyleBackColor = false;
            // 
            // CerrarButton
            // 
            this.CerrarButton.Location = new System.Drawing.Point(1709, 10);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(83, 71);
            this.CerrarButton.TabIndex = 3;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = true;
            // 
            // EditarIconButton
            // 
            this.EditarIconButton.Location = new System.Drawing.Point(184, 10);
            this.EditarIconButton.Name = "EditarIconButton";
            this.EditarIconButton.Size = new System.Drawing.Size(83, 69);
            this.EditarIconButton.TabIndex = 2;
            this.EditarIconButton.Text = "Editar";
            this.EditarIconButton.UseVisualStyleBackColor = true;
            // 
            // BorrarIconButton
            // 
            this.BorrarIconButton.Location = new System.Drawing.Point(95, 10);
            this.BorrarIconButton.Name = "BorrarIconButton";
            this.BorrarIconButton.Size = new System.Drawing.Size(83, 69);
            this.BorrarIconButton.TabIndex = 1;
            this.BorrarIconButton.Text = "Borrar";
            this.BorrarIconButton.UseVisualStyleBackColor = true;
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
            this.splitContainer1.Panel1.Controls.Add(this.PrecioDescIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.OredenarAZPorProductoiconButton);
            this.splitContainer1.Panel1.Controls.Add(this.FiltrariconButton);
            this.splitContainer1.Panel1.Controls.Add(this.CerrarButton);
            this.splitContainer1.Panel1.Controls.Add(this.EditarIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.BorrarIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.NuevoIconButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DatosDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1804, 539);
            this.splitContainer1.SplitterDistance = 97;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 7;
            // 
            // NuevoIconButton
            // 
            this.NuevoIconButton.Location = new System.Drawing.Point(6, 10);
            this.NuevoIconButton.Name = "NuevoIconButton";
            this.NuevoIconButton.Size = new System.Drawing.Size(83, 69);
            this.NuevoIconButton.TabIndex = 0;
            this.NuevoIconButton.Text = "Nuevo";
            this.NuevoIconButton.UseVisualStyleBackColor = true;
            this.NuevoIconButton.Click += new System.EventHandler(this.NuevoIconButton_Click);
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DatosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colApellido,
            this.colTipoDeDocumento,
            this.colNroDocumento,
            this.colDireccion,
            this.colLocalidad,
            this.colProvincia,
            this.colPais,
            this.colTelefonoFijo,
            this.colTelefonoMovil,
            this.colCorreoElectronico});
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
            this.DatosDataGridView.Size = new System.Drawing.Size(1804, 437);
            this.DatosDataGridView.TabIndex = 0;
            // 
            // colTelefonoMovil
            // 
            this.colTelefonoMovil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTelefonoMovil.HeaderText = "Telefono Movil";
            this.colTelefonoMovil.MinimumWidth = 6;
            this.colTelefonoMovil.Name = "colTelefonoMovil";
            this.colTelefonoMovil.ReadOnly = true;
            this.colTelefonoMovil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmClientes
            // 
            this.ClientSize = new System.Drawing.Size(1804, 539);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefonoFijo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoDeDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private FontAwesome.Sharp.IconButton PrecioDescIconButton;
        private FontAwesome.Sharp.IconButton OredenarAZPorProductoiconButton;
        private FontAwesome.Sharp.IconButton FiltrariconButton;
        private System.Windows.Forms.Button CerrarButton;
        private System.Windows.Forms.Button EditarIconButton;
        private System.Windows.Forms.Button BorrarIconButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button NuevoIconButton;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefonoMovil;
    }
}