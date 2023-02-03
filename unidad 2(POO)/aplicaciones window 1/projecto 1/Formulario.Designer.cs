namespace projecto_1
{
    partial class Formulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BtnColor = new System.Windows.Forms.Button();
            this.TxtNumeros = new System.Windows.Forms.TextBox();
            this.TxtLetras = new System.Windows.Forms.TextBox();
            this.LblEtiqueta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnColor
            // 
            this.BtnColor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnColor.ForeColor = System.Drawing.SystemColors.Info;
            this.BtnColor.Image = ((System.Drawing.Image)(resources.GetObject("BtnColor.Image")));
            this.BtnColor.Location = new System.Drawing.Point(314, 125);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(128, 37);
            this.BtnColor.TabIndex = 0;
            this.BtnColor.Text = "Boton 1";
            this.BtnColor.UseVisualStyleBackColor = false;
            this.BtnColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtNumeros
            // 
            this.TxtNumeros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNumeros.Location = new System.Drawing.Point(153, 125);
            this.TxtNumeros.MaxLength = 10;
            this.TxtNumeros.Multiline = true;
            this.TxtNumeros.Name = "TxtNumeros";
            this.TxtNumeros.Size = new System.Drawing.Size(128, 37);
            this.TxtNumeros.TabIndex = 1;
            this.TxtNumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBox_KeyPress);
            // 
            // TxtLetras
            // 
            this.TxtLetras.Location = new System.Drawing.Point(153, 241);
            this.TxtLetras.Multiline = true;
            this.TxtLetras.Name = "TxtLetras";
            this.TxtLetras.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtLetras.Size = new System.Drawing.Size(249, 51);
            this.TxtLetras.TabIndex = 2;
            this.TxtLetras.Leave += new System.EventHandler(this.TxtLetras_Leave);
            // 
            // LblEtiqueta
            // 
            this.LblEtiqueta.AutoSize = true;
            this.LblEtiqueta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblEtiqueta.Font = new System.Drawing.Font("Impact", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEtiqueta.ForeColor = System.Drawing.SystemColors.MenuText;
            this.LblEtiqueta.Location = new System.Drawing.Point(587, 189);
            this.LblEtiqueta.Name = "LblEtiqueta";
            this.LblEtiqueta.Size = new System.Drawing.Size(57, 20);
            this.LblEtiqueta.TabIndex = 3;
            this.LblEtiqueta.Text = "etiqueta";
            this.LblEtiqueta.MouseLeave += new System.EventHandler(this.LblEtiqueta_MouseLeave);
            this.LblEtiqueta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblEtiqueta);
            this.Controls.Add(this.TxtLetras);
            this.Controls.Add(this.TxtNumeros);
            this.Controls.Add(this.BtnColor);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentForm";
            this.Closed += new System.EventHandler(this.Formulario_Closed);
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.Click += new System.EventHandler(this.Formulario_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BtnColor;
        private System.Windows.Forms.TextBox TxtNumeros;
        private System.Windows.Forms.TextBox TxtLetras;
        private System.Windows.Forms.Label LblEtiqueta;
    }
}

