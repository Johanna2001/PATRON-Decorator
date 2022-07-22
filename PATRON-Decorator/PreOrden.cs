using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRON_Decorator
{
    class PreOrden:OrdenBase
    {
        public override double CalcularTotalPrecioOrden()
        {
            Console.WriteLine("Cálculo del precio total de un pedido anticipado");
            return producto.Sum(x => x.Precio)*0.9;
        }
    }
}
