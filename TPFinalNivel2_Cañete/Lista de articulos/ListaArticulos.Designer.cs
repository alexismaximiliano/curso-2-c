namespace Lista_de_articulos
{
    partial class FrmListaArticulos
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
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.PtBImagen = new System.Windows.Forms.PictureBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnDetalles = new System.Windows.Forms.Button();
            this.LblCampo = new System.Windows.Forms.Label();
            this.CmBCampo = new System.Windows.Forms.ComboBox();
            this.LblCriterio = new System.Windows.Forms.Label();
            this.CmBCriterio = new System.Windows.Forms.ComboBox();
            this.LblFiltro = new System.Windows.Forms.Label();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtBImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvLista
            // 
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Location = new System.Drawing.Point(42, 32);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.Size = new System.Drawing.Size(454, 269);
            this.DgvLista.TabIndex = 0;
            // 
            // PtBImagen
            // 
            this.PtBImagen.Location = new System.Drawing.Point(517, 32);
            this.PtBImagen.Name = "PtBImagen";
            this.PtBImagen.Size = new System.Drawing.Size(250, 269);
            this.PtBImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtBImagen.TabIndex = 1;
            this.PtBImagen.TabStop = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(42, 318);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(124, 318);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 3;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(206, 318);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnDetalles
            // 
            this.BtnDetalles.Location = new System.Drawing.Point(288, 318);
            this.BtnDetalles.Name = "BtnDetalles";
            this.BtnDetalles.Size = new System.Drawing.Size(75, 23);
            this.BtnDetalles.TabIndex = 5;
            this.BtnDetalles.Text = "Detalles";
            this.BtnDetalles.UseVisualStyleBackColor = true;
            // 
            // LblCampo
            // 
            this.LblCampo.AutoSize = true;
            this.LblCampo.Location = new System.Drawing.Point(34, 368);
            this.LblCampo.Name = "LblCampo";
            this.LblCampo.Size = new System.Drawing.Size(43, 13);
            this.LblCampo.TabIndex = 6;
            this.LblCampo.Text = "Campo:";
            // 
            // CmBCampo
            // 
            this.CmBCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmBCampo.FormattingEnabled = true;
            this.CmBCampo.Location = new System.Drawing.Point(83, 365);
            this.CmBCampo.Name = "CmBCampo";
            this.CmBCampo.Size = new System.Drawing.Size(121, 21);
            this.CmBCampo.TabIndex = 7;
            // 
            // LblCriterio
            // 
            this.LblCriterio.AutoSize = true;
            this.LblCriterio.Location = new System.Drawing.Point(210, 368);
            this.LblCriterio.Name = "LblCriterio";
            this.LblCriterio.Size = new System.Drawing.Size(42, 13);
            this.LblCriterio.TabIndex = 8;
            this.LblCriterio.Text = "Criterio:";
            // 
            // CmBCriterio
            // 
            this.CmBCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmBCriterio.FormattingEnabled = true;
            this.CmBCriterio.Location = new System.Drawing.Point(258, 365);
            this.CmBCriterio.Name = "CmBCriterio";
            this.CmBCriterio.Size = new System.Drawing.Size(121, 21);
            this.CmBCriterio.TabIndex = 9;
            // 
            // LblFiltro
            // 
            this.LblFiltro.AutoSize = true;
            this.LblFiltro.Location = new System.Drawing.Point(385, 368);
            this.LblFiltro.Name = "LblFiltro";
            this.LblFiltro.Size = new System.Drawing.Size(32, 13);
            this.LblFiltro.TabIndex = 10;
            this.LblFiltro.Text = "Filtro:";
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Location = new System.Drawing.Point(423, 365);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(100, 20);
            this.TxtFiltro.TabIndex = 11;
            // 
            // FrmListaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(797, 411);
            this.Controls.Add(this.TxtFiltro);
            this.Controls.Add(this.LblFiltro);
            this.Controls.Add(this.CmBCriterio);
            this.Controls.Add(this.LblCriterio);
            this.Controls.Add(this.CmBCampo);
            this.Controls.Add(this.LblCampo);
            this.Controls.Add(this.BtnDetalles);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.PtBImagen);
            this.Controls.Add(this.DgvLista);
            this.Name = "FrmListaArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Articulos";
            this.Load += new System.EventHandler(this.FrmListaArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtBImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.PictureBox PtBImagen;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnDetalles;
        private System.Windows.Forms.Label LblCampo;
        private System.Windows.Forms.ComboBox CmBCampo;
        private System.Windows.Forms.Label LblCriterio;
        private System.Windows.Forms.ComboBox CmBCriterio;
        private System.Windows.Forms.Label LblFiltro;
        private System.Windows.Forms.TextBox TxtFiltro;
    }
}