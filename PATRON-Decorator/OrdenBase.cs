using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRON_Decorator
{
    abstract class OrdenBase
    {
        //para que solo pueda ser usada por ella y sus hijas
        protected List<Productos> producto = new List<Productos>
        {
            new Productos{Nombre = "Telefono", Precio = 300},
            new Productos{Nombre = "Tablet", Precio = 800},
            new Productos{Nombre = "PC Gamer", Precio = 1000}
        };
        public abstract double CalcularTotalPrecioOrden();

    }
}
