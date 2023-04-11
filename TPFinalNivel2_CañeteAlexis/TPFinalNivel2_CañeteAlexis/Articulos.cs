using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalNivel2_CañeteAlexis
{
    internal class Articulos
    {
        public string Nombre { get; set; }
        public string ImagenUrl { get; set; }
        public decimal Precio { get; set; }
        //public string Descripcion { get; set; }
        public Marcas Marca { get; set; }
        public Categoria Categoria { get; set; }
    }
}
