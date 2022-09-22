using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCS11
{
    // Ejemplo 7: Auto-inicialización de miembros de structs
    internal struct Punto
    {
        public Punto()
        {
           
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
