using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Funciones;

namespace TPFinalNivel2_CañeteAlexis
{
    public partial class FrmDetalles : Form
    {
        private Articulos articulo = null;
        public FrmDetalles()
        {
            InitializeComponent();
        }
        public FrmDetalles(Articulos articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void FrmDetalles_Load(object sender, EventArgs e)
        {
            try
            {
                if (articulo != null)
                 {
                    TxtCodigo.Text = articulo.Codigo;//
                    TxtNombre.Text = articulo.Nombre;
                    TxtDescripcion.Text = articulo.Descripcion;//
                    TxtMarca.Text = articulo.Marca.Descripcion;
                    TxtCategoria.Text = articulo.Categoria.Descripcion;
                    TxtPrecio.Text = articulo.Precio.ToString();
                    CargarImagen(articulo.ImagenUrl);
                 }               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            

        }
        private void CargarImagen(string imagen)
        {
            try
            {
                PtbImagen.Load(imagen);
            }
            catch (Exception)
            {

                PtbImagen.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");
            }
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
