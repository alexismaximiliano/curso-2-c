using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using funciones;

namespace Lista_de_articulos
{
    public partial class FrmListaArticulos : Form
    {
        private List<Articulos> ListaArticulos;
        public FrmListaArticulos()
        {
            InitializeComponent();
        }
         private void FrmListaArticulos_Load(object sender, EventArgs e)
        {
            cargar();
            
        }
        private void cargar()
        {
            Funciones cargar = new Funciones();
            try
            {
                ListaArticulos = cargar.listar();
                DgvLista.DataSource = ListaArticulos;
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
        }
    }
}
