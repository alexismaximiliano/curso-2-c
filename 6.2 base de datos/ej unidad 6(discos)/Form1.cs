using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej_unidad_6_discos_
{
    public partial class FrmDiscos : Form
    {
        private List<Discos> discosLista;
        public FrmDiscos()
        {
            InitializeComponent();
        }

        private void FrmDiscos_Load(object sender, EventArgs e)
        {
            DiscosListas discos = new DiscosListas();
            discosLista = discos.Listar();
            DgvDiscos.DataSource = discosLista;
            DgvDiscos.Columns["Url"].Visible = false;
            Cargar(discosLista[1].UrlTapa);
        }

        private void DgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Discos seleccionado = (Discos)DgvDiscos.CurrentRow.DataBoundItem;
            Cargar(seleccionado.UrlTapa);
        }
        private void Cargar(string imagen) {
            try
            {
                PtbDiscos.Load(imagen);
            }
            catch (Exception )
            {

                PtbDiscos.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

    } 
}

