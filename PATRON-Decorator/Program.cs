using System;

namespace PATRON_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var RegularOrden = new OrdenRegular();
            Console.WriteLine(RegularOrden.CalcularTotalPrecioOrden());
            Console.WriteLine();

            var preOrden = new PreOrden();
            Console.WriteLine(preOrden.CalcularTotalPrecioOrden());
            Console.WriteLine();

            var ordenPremium = new OrdenPremium(preOrden);
            Console.WriteLine(ordenPremium.CalcularTotalPrecioOrden());
            Console.WriteLine();
        }
    }
}
