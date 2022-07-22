using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRON_Decorator
{
    class OrdenPremium: Decorador
    {
        public OrdenPremium (OrdenBase orden): base(orden) { }
        public override double CalcularTotalPrecioOrden()
        {
            Console.WriteLine($"Cálculo del precio total en la clase {nameof(OrdenPremium)}.");
            var preOredenprecio = base.CalcularTotalPrecioOrden();
            Console.WriteLine("Adicion de un descuento adicional al precio anticipado");
            return preOredenprecio * 0.9;
        }
    }
}
