namespace _6._2_base_de_datos
{
    partial class Form1
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
            this.dgvpokemon = new System.Windows.Forms.DataGridView();
            this.pbxpokemon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxpokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvpokemon
            // 
            this.dgvpokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpokemon.Location = new System.Drawing.Point(12, 23);
            this.dgvpokemon.Name = "dgvpokemon";
            this.dgvpokemon.Size = new System.Drawing.Size(383, 262);
            this.dgvpokemon.TabIndex = 0;
            this.dgvpokemon.SelectionChanged += new System.EventHandler(this.dgvpokemon_SelectionChanged);
            // 
            // pbxpokemon
            // 
            this.pbxpokemon.Location = new System.Drawing.Point(459, 23);
            this.pbxpokemon.Name = "pbxpokemon";
            this.pbxpokemon.Size = new System.Drawing.Size(273, 262);
            this.pbxpokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxpokemon.TabIndex = 1;
            this.pbxpokemon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxpokemon);
            this.Controls.Add(this.dgvpokemon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxpokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvpokemon;
        private System.Windows.Forms.PictureBox pbxpokemon;
    }
}

