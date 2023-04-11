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
    public partial class FrmAgregar : Form
    {
        private Articulos articulo=null;
        public FrmAgregar()
        {
            InitializeComponent();
        }
        public FrmAgregar(Articulos articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modicar";
        }

        private void FrmAgregar_Load(object sender, EventArgs e)
        {
            FuncionesCategorias categoria = new FuncionesCategorias();
            FuncionesMarcas marca = new FuncionesMarcas();
            
            try
            {
                
                CboCategoria.DataSource = categoria.listar();
                CboCategoria.ValueMember = "Id";
                CboCategoria.DisplayMember = "Descripcion";
                CboMarca.DataSource = marca.listar();
                CboMarca.ValueMember = "Id";
                CboMarca.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    
                    TxtCodigo.Text = articulo.Codigo;
                    TxtNombre.Text = articulo.Nombre;
                    TxtDescripcion.Text = articulo.Descripcion;
                    TxtPrecio.Text = articulo.Precio.ToString();
                    TxtImagen.Text = articulo.ImagenUrl;
                    CargarImagen(articulo.ImagenUrl);                    
                    CboCategoria.SelectedValue = articulo.Categoria.Id;
                    CboCategoria.Text = articulo.Categoria.Descripcion;
                    CboMarca.SelectedValue = articulo.Marca.Id;
                    CboMarca.Text = articulo.Marca.Descripcion;                   
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show (ex.ToString());
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
             
            FuncionesArticulos funcion = new FuncionesArticulos();
            
            try
            {
                if (articulo == null)
                    articulo = new Articulos();
                articulo.Codigo = TxtCodigo.Text;
                articulo.Nombre = TxtNombre.Text;
                articulo.Descripcion = TxtDescripcion.Text;
                articulo.Precio = decimal.Parse(TxtPrecio.Text);
                articulo.ImagenUrl = TxtImagen.Text;
                articulo.Categoria =(Categorias)CboCategoria.SelectedItem;
                articulo.Marca = (Marcas)CboMarca.SelectedItem;
                if (articulo.Id != 0) {
                    funcion.Modificar(articulo);
                    MessageBox.Show("Modificado");
                }
                else
                {
                    funcion.Agregar(articulo);
                    MessageBox.Show("Agregado");
                }               
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void TxtImagen_Leave(object sender, EventArgs e)
        {
            CargarImagen(TxtImagen.Text);
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
    }
}

    
