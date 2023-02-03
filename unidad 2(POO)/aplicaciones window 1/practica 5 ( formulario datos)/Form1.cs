using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_5___formulario_datos_
{
    public partial class FormDatos : Form
    {
        public FormDatos()
        {
            InitializeComponent();
        }

        

        

        private void LblApellido_Click(object sender, EventArgs e)
        {

        }

        private void LblNombre_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtApellido.Text != "" || TxtNombre.Text != "" || TxtDireccion.Text != "" || TxtEdad.Text != "")
                TxtResultado.Text = "Apellido y Nombre: " + TxtApellido.Text + " " + TxtNombre.Text + Environment.NewLine + "Edad: "+ TxtEdad.Text + Environment.NewLine + "Direccion: " + TxtDireccion.Text ;                          
            if (TxtApellido.Text == "")
                TxtApellido.BackColor = Color.Red;
            else
                TxtApellido.BackColor = Color.White;
            if (TxtDireccion.Text == "")
                TxtDireccion.BackColor = Color.Red;
            else
                TxtDireccion.BackColor = Color.White;
            if(TxtEdad.Text=="")
                TxtEdad.BackColor = Color.Red;
            else
            TxtEdad.BackColor= Color.White;
            if(TxtNombre.Text=="")
                TxtNombre.BackColor= Color.Red;
            else
                TxtNombre.BackColor= Color.White;
        }

        private void TxtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<48 ||e.KeyChar>59)&& e.KeyChar !=8)
                e.Handled= true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
