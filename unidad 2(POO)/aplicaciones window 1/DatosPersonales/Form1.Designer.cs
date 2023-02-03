namespace DatosPersonales
{
    partial class FormDatos
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
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblEdad = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.Txtdirecion = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(88, 61);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(50, 12);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "NOMBRE";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(88, 118);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(58, 12);
            this.LblApellido.TabIndex = 1;
            this.LblApellido.Text = "APELLIDO";
            // 
            // LblEdad
            // 
            this.LblEdad.AutoSize = true;
            this.LblEdad.Location = new System.Drawing.Point(91, 159);
            this.LblEdad.Name = "LblEdad";
            this.LblEdad.Size = new System.Drawing.Size(33, 12);
            this.LblEdad.TabIndex = 2;
            this.LblEdad.Text = "EDAD";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Location = new System.Drawing.Point(91, 201);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(62, 12);
            this.LblDireccion.TabIndex = 3;
            this.LblDireccion.Text = "DIRECCION";
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Location = new System.Drawing.Point(91, 253);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(67, 12);
            this.LblResultado.TabIndex = 4;
            this.LblResultado.Text = "RESULTADO";
            // 
            // TxtNombre
            // 
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Location = new System.Drawing.Point(176, 61);
            this.TxtNombre.MaxLength = 99;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(250, 20);
            this.TxtNombre.TabIndex = 5;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // TxtApellido
            // 
            this.TxtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtApellido.Location = new System.Drawing.Point(176, 110);
            this.TxtApellido.MaxLength = 99;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(250, 20);
            this.TxtApellido.TabIndex = 6;
            this.TxtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // TxtEdad
            // 
            this.TxtEdad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtEdad.Location = new System.Drawing.Point(176, 151);
            this.TxtEdad.MaxLength = 2;
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(58, 20);
            this.TxtEdad.TabIndex = 7;
            this.TxtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // TxtResultado
            // 
            this.TxtResultado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtResultado.Location = new System.Drawing.Point(93, 285);
            this.TxtResultado.MaxLength = 999;
            this.TxtResultado.Multiline = true;
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(333, 102);
            this.TxtResultado.TabIndex = 8;
            this.TxtResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // Txtdirecion
            // 
            this.Txtdirecion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtdirecion.Location = new System.Drawing.Point(176, 198);
            this.Txtdirecion.MaxLength = 99;
            this.Txtdirecion.Name = "Txtdirecion";
            this.Txtdirecion.Size = new System.Drawing.Size(250, 20);
            this.Txtdirecion.TabIndex = 9;
            this.Txtdirecion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.AutoSize = true;
            this.BtnAceptar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAceptar.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAceptar.Location = new System.Drawing.Point(159, 412);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 24);
            this.BtnAceptar.TabIndex = 10;
            this.BtnAceptar.Text = "ACEPTAR";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.AutoSize = true;
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCancelar.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCancelar.Location = new System.Drawing.Point(309, 412);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(79, 24);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FormDatos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(505, 461);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.Txtdirecion);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.LblEdad);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombre);
            this.Font = new System.Drawing.Font("Liberation Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Personales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblEdad;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.TextBox Txtdirecion;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}

