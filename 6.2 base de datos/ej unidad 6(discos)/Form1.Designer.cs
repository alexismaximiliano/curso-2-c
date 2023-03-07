namespace ej_unidad_6_discos_
{
    partial class FrmDiscos
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
            this.DgvDiscos = new System.Windows.Forms.DataGridView();
            this.PtbDiscos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDiscos
            // 
            this.DgvDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDiscos.Location = new System.Drawing.Point(12, 42);
            this.DgvDiscos.Name = "DgvDiscos";
            this.DgvDiscos.Size = new System.Drawing.Size(446, 287);
            this.DgvDiscos.TabIndex = 0;
            this.DgvDiscos.SelectionChanged += new System.EventHandler(this.DgvDiscos_SelectionChanged);
            // 
            // PtbDiscos
            // 
            this.PtbDiscos.Location = new System.Drawing.Point(497, 42);
            this.PtbDiscos.Name = "PtbDiscos";
            this.PtbDiscos.Size = new System.Drawing.Size(281, 287);
            this.PtbDiscos.TabIndex = 1;
            this.PtbDiscos.TabStop = false;
            // 
            // FrmDiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PtbDiscos);
            this.Controls.Add(this.DgvDiscos);
            this.Name = "FrmDiscos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discos";
            this.Load += new System.EventHandler(this.FrmDiscos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbDiscos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDiscos;
        private System.Windows.Forms.PictureBox PtbDiscos;
    }
}

