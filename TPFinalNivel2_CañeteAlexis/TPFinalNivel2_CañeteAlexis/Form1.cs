using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using Funciones;

    

namespace TPFinalNivel2_CañeteAlexis
{
    public partial class ListaArticulos : Form
    {
        private List<Articulos> ListArticulos;
        public ListaArticulos()
        {
            InitializeComponent();
        }

        private void ListaArticulos_Load(object sender, EventArgs e)
        {
            CargarLista();
            CboCampo.Items.Add("Precio");
            CboCampo.Items.Add("Marca");
            CboCampo.Items.Add("Categoria");
            //OcultarBoton();
        }
        private void DgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvArticulos.CurrentRow != null)
            {
                Articulos seleccionado = (Articulos)DgvArticulos.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.ImagenUrl);
                OcultarBoton();
            }
            else
                OcultarBoton();
        }
        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> ListaFiltrada;
            string Filtro = TxtFiltroRapido.Text;
            if (Filtro.Length>=1)
            {
                ListaFiltrada = ListArticulos.FindAll(x => x.Nombre.ToLower().Contains(Filtro.ToLower()));
            }
            else
            {
                ListaFiltrada = ListArticulos;
            }
            DgvArticulos.DataSource = null;
            DgvArticulos.DataSource = ListaFiltrada;
            OcultarColumnas();
        }
        private void CboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Opcion = CboCampo.SelectedItem.ToString();
            if (Opcion == "Precio")
            {
                CboCriterio.Items.Clear();
                CboCriterio.Items.Add("Mayor a");
                CboCriterio.Items.Add("Menor a");
                CboCriterio.Items.Add("Igual a");
            }
            else
            {
                CboCriterio.Items.Clear();
                CboCriterio.Items.Add("Comienza con");
                CboCriterio.Items.Add("Termina con");
                CboCriterio.Items.Add("Contiene");
            }
        }
        
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregar agregar = new FrmAgregar();
            agregar.ShowDialog();
            CargarLista();
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Articulos selecionado;
            selecionado = (Articulos)DgvArticulos.CurrentRow.DataBoundItem;
            FrmAgregar Modificar = new FrmAgregar(selecionado);
            Modificar.ShowDialog();
            CargarLista();
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            FuncionesArticulos eliminar = new FuncionesArticulos();
            Articulos seleccionado;
            try
            {
                DialogResult Resultado = MessageBox.Show("Eliminar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (Resultado == DialogResult.Yes)
                {
                seleccionado = (Articulos)DgvArticulos.CurrentRow.DataBoundItem;
                eliminar.eliminar(seleccionado.Id);
                CargarLista();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void BtnFiltro_Click(object sender, EventArgs e)
        {
            FuncionesArticulos funcion = new FuncionesArticulos();
            try
            {
                if (ValidarFiltro())
                    return;
                string Campo = CboCampo.SelectedItem.ToString();
                string Criterio = CboCriterio.SelectedItem.ToString();
                string Filtro = TxtFiltro.Text;
                DgvArticulos.DataSource = funcion.filtrar(Campo,Criterio,Filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void BtnDetalles_Click(object sender, EventArgs e)
        {
            Articulos selecionado=new Articulos();          
            selecionado = (Articulos)DgvArticulos.CurrentRow.DataBoundItem;
            FrmDetalles detalles=new FrmDetalles(selecionado);
            detalles.ShowDialog();                     
        }
        
        private void CargarLista()
        {
            FuncionesArticulos funcion = new FuncionesArticulos();
            try
            {
                
                ListArticulos = funcion.listar();
                DgvArticulos.DataSource = ListArticulos;
                OcultarColumnas();
                CargarImagen(ListArticulos[0].ImagenUrl);
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
                PtbArticulo.Load(imagen);
            }
            catch (Exception)
            {

                PtbArticulo.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");
            }
        }
        private bool ValidarFiltro()
        {
            if (CboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione campo");
                return true;
            }
            if (CboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione criterio");
                return true;
            }
            if (CboCampo.SelectedItem.ToString() == "Numero")
            {
                if (string.IsNullOrEmpty(TxtFiltro.Text))
                {
                    MessageBox.Show("Filtro para numeros");
                    return true;
                }
                if (!(SoloNumeros(TxtFiltro.Text)))
                {
                    MessageBox.Show("Solo numeros en el filtro");
                    return true;
                }
            }
            return false;
        }
        private bool SoloNumeros(string Cadena) 
        {
            foreach (char Caracter in Cadena)
            {
                if (!(char.IsNumber(Caracter)))
                    return false;
            }
            return true;
        }       
        private void OcultarColumnas()
        {
            DgvArticulos.Columns["ImagenUrl"].Visible = false;
            DgvArticulos.Columns["Id"].Visible = false;
            DgvArticulos.Columns["Descripcion"].Visible = false;
            DgvArticulos.Columns["Codigo"].Visible = false;
        }
        private void OcultarBoton()
        {
            if (DgvArticulos.CurrentRow != null)
            {
                BtnDetalles.Enabled = true;
                BtnEliminar.Enabled = true;
                BtnModificar.Enabled = true;
            }

            else
            {
                BtnDetalles.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnModificar.Enabled = false;
            }
            //agregar codigo y descripcion en frm agregar y modificar

        }
    }  
}
