namespace Lista_de_articulos
{
    partial class FrmListaArticulos
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
            this.DgvListaArticulos = new System.Windows.Forms.DataGridView();
            this.PtbArticulo = new System.Windows.Forms.PictureBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnDetalles = new System.Windows.Forms.Button();
            this.CboCampo = new System.Windows.Forms.ComboBox();
            this.CboCriterio = new System.Windows.Forms.ComboBox();
            this.LblCampo = new System.Windows.Forms.Label();
            this.LblCriterio = new System.Windows.Forms.Label();
            this.TxtbFiltro = new System.Windows.Forms.TextBox();
            this.LblFiltro = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvListaArticulos
            // 
            this.DgvListaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaArticulos.Location = new System.Drawing.Point(46, 51);
            this.DgvListaArticulos.Name = "DgvListaArticulos";
            this.DgvListaArticulos.Size = new System.Drawing.Size(481, 255);
            this.DgvListaArticulos.TabIndex = 0;
            // 
            // PtbArticulo
            // 
            this.PtbArticulo.Location = new System.Drawing.Point(554, 51);
            this.PtbArticulo.Name = "PtbArticulo";
            this.PtbArticulo.Size = new System.Drawing.Size(231, 255);
            this.PtbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbArticulo.TabIndex = 1;
            this.PtbArticulo.TabStop = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(46, 312);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(127, 312);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 3;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(208, 312);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnDetalles
            // 
            this.BtnDetalles.Location = new System.Drawing.Point(289, 312);
            this.BtnDetalles.Name = "BtnDetalles";
            this.BtnDetalles.Size = new System.Drawing.Size(75, 23);
            this.BtnDetalles.TabIndex = 5;
            this.BtnDetalles.Text = "Detalles";
            this.BtnDetalles.UseVisualStyleBackColor = true;
            // 
            // CboCampo
            // 
            this.CboCampo.FormattingEnabled = true;
            this.CboCampo.Location = new System.Drawing.Point(92, 356);
            this.CboCampo.Name = "CboCampo";
            this.CboCampo.Size = new System.Drawing.Size(121, 21);
            this.CboCampo.TabIndex = 6;
            this.CboCampo.SelectedIndexChanged += new System.EventHandler(this.CboCampo_SelectedIndexChanged);
            // 
            // CboCriterio
            // 
            this.CboCriterio.FormattingEnabled = true;
            this.CboCriterio.Location = new System.Drawing.Point(276, 356);
            this.CboCriterio.Name = "CboCriterio";
            this.CboCriterio.Size = new System.Drawing.Size(121, 21);
            this.CboCriterio.TabIndex = 7;
            // 
            // LblCampo
            // 
            this.LblCampo.AutoSize = true;
            this.LblCampo.Location = new System.Drawing.Point(46, 359);
            this.LblCampo.Name = "LblCampo";
            this.LblCampo.Size = new System.Drawing.Size(43, 13);
            this.LblCampo.TabIndex = 8;
            this.LblCampo.Text = "Campo:";
            // 
            // LblCriterio
            // 
            this.LblCriterio.AutoSize = true;
            this.LblCriterio.Location = new System.Drawing.Point(228, 359);
            this.LblCriterio.Name = "LblCriterio";
            this.LblCriterio.Size = new System.Drawing.Size(42, 13);
            this.LblCriterio.TabIndex = 9;
            this.LblCriterio.Text = "Criterio:";
            // 
            // TxtbFiltro
            // 
            this.TxtbFiltro.Location = new System.Drawing.Point(452, 356);
            this.TxtbFiltro.Name = "TxtbFiltro";
            this.TxtbFiltro.Size = new System.Drawing.Size(100, 20);
            this.TxtbFiltro.TabIndex = 10;
            // 
            // LblFiltro
            // 
            this.LblFiltro.AutoSize = true;
            this.LblFiltro.Location = new System.Drawing.Point(414, 359);
            this.LblFiltro.Name = "LblFiltro";
            this.LblFiltro.Size = new System.Drawing.Size(32, 13);
            this.LblFiltro.TabIndex = 11;
            this.LblFiltro.Text = "Filtro:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(567, 353);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 12;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // FrmListaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(797, 404);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.LblFiltro);
            this.Controls.Add(this.TxtbFiltro);
            this.Controls.Add(this.LblCriterio);
            this.Controls.Add(this.LblCampo);
            this.Controls.Add(this.CboCriterio);
            this.Controls.Add(this.CboCampo);
            this.Controls.Add(this.BtnDetalles);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.PtbArticulo);
            this.Controls.Add(this.DgvListaArticulos);
            this.Name = "FrmListaArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de articulos";
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListaArticulos;
        private System.Windows.Forms.PictureBox PtbArticulo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnDetalles;
        private System.Windows.Forms.ComboBox CboCampo;
        private System.Windows.Forms.ComboBox CboCriterio;
        private System.Windows.Forms.Label LblCampo;
        private System.Windows.Forms.Label LblCriterio;
        private System.Windows.Forms.TextBox TxtbFiltro;
        private System.Windows.Forms.Label LblFiltro;
        private System.Windows.Forms.Button BtnBuscar;
    }
}

