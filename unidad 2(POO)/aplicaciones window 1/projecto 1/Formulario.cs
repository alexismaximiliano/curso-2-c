using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace projecto_1
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            MessageBox.Show("hola mundo");//como printf
        }

        private void Formulario_Closed(object sender, EventArgs e)
        {
            MessageBox.Show("chau");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("evento click", "color");
            //this.BackColor = Color.CadetBlue;
            if (TxtNumeros.Text == "")
                TxtNumeros.BackColor = Color.Red;
            else
                TxtNumeros.BackColor = Color.Green;//System.Drawing.SystemColors.Control;
        }

        private void Formulario_Click(object sender, EventArgs e)
        {
            MouseEventArgs Click = (MouseEventArgs)e;
            if (Click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "izquierdo");
            else if (Click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "derecho");
            else
            if (Click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio", "medio");
        }

        private void TxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59)&&e.KeyChar!=8)
                    e.Handled = true;
        }

        private void TxtLetras_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("tiene" + TxtLetras.Text.Length + "letras");
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            LblEtiqueta.BackColor = Color.Cyan;
            LblEtiqueta.Cursor = Cursors.Hand;
        }

        private void LblEtiqueta_MouseLeave(object sender, EventArgs e)
        {
            LblEtiqueta.BackColor = System.Drawing.SystemColors.Control;
            LblEtiqueta.Cursor = Cursors.Arrow;
        }
    }
}
