namespace practica_5___formulario_datos_
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
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblEDAD = new System.Windows.Forms.Label();
            this.LblDirecion = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.Location = new System.Drawing.Point(77, 31);
            this.LblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(73, 15);
            this.LblApellido.TabIndex = 0;
            this.LblApellido.Text = "APELLIDO";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(77, 77);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(67, 15);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "NOMBRE";
            // 
            // LblEDAD
            // 
            this.LblEDAD.AutoSize = true;
            this.LblEDAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEDAD.Location = new System.Drawing.Point(77, 123);
            this.LblEDAD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEDAD.Name = "LblEDAD";
            this.LblEDAD.Size = new System.Drawing.Size(44, 15);
            this.LblEDAD.TabIndex = 2;
            this.LblEDAD.Text = "EDAD";
            // 
            // LblDirecion
            // 
            this.LblDirecion.AutoSize = true;
            this.LblDirecion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDirecion.Location = new System.Drawing.Point(77, 178);
            this.LblDirecion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDirecion.Name = "LblDirecion";
            this.LblDirecion.Size = new System.Drawing.Size(82, 15);
            this.LblDirecion.TabIndex = 3;
            this.LblDirecion.Text = "DIRECCION";
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(77, 237);
            this.LblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(89, 15);
            this.LblResultado.TabIndex = 4;
            this.LblResultado.Text = "RESULTADO";
            // 
            // TxtApellido
            // 
            this.TxtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtApellido.Location = new System.Drawing.Point(166, 28);
            this.TxtApellido.MaxLength = 100;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(278, 21);
            this.TxtApellido.TabIndex = 5;
            this.TxtApellido.TextChanged += new System.EventHandler(this.TxtApellido_TextChanged);
            // 
            // TxtNombre
            // 
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Location = new System.Drawing.Point(166, 77);
            this.TxtNombre.MaxLength = 100;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(278, 21);
            this.TxtNombre.TabIndex = 6;
            // 
            // TxtEdad
            // 
            this.TxtEdad.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TxtEdad.Location = new System.Drawing.Point(166, 120);
            this.TxtEdad.MaxLength = 2;
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(65, 21);
            this.TxtEdad.TabIndex = 7;
            this.TxtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEdad_KeyPress);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDireccion.Location = new System.Drawing.Point(166, 178);
            this.TxtDireccion.MaxLength = 100;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(278, 21);
            this.TxtDireccion.TabIndex = 8;
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(80, 267);
            this.TxtResultado.Multiline = true;
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(364, 122);
            this.TxtResultado.TabIndex = 9;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(136, 428);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 10;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(294, 428);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(464, 484);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.LblDirecion);
            this.Controls.Add(this.LblEDAD);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblApellido);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormDatos";
            this.Text = "Datos Personales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblEDAD;
        private System.Windows.Forms.Label LblDirecion;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}

