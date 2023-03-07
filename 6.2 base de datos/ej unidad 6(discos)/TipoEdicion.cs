using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_unidad_6_discos_
{
    internal class TipoEdicion
    {
        public int Id { get; set; }
        public string  Edicion { get; set; }
        public override string ToString()
        {
            return Edicion;
        }
    }
}
