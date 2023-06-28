using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_articulos
{
    public partial class Dominio : Component
    {
        public Dominio()
        {
            InitializeComponent();
        }

        public Dominio(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
