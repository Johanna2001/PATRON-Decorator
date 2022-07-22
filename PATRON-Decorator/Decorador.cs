using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRON_Decorator
{
    class Decorador: OrdenBase
    {
        protected OrdenBase orden;
        public Decorador (OrdenBase orden)
        {
            this.orden = orden;
        }
        public override double CalcularTotalPrecioOrden()
        {
            Console.WriteLine("Cálculo del precio total desde la clase decorador");
            return orden.CalcularTotalPrecioOrden();
        }
    }
}
