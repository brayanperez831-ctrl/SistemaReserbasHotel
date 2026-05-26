using System;

namespace HotelReservas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Estructura inicial del sistema de reservas
        }
    }
}
using System;

namespace HotelReservas
{
    internal class Program
    {
        static void Main(string[] args) { }

        // Métodos de cálculo
        static double CalcularSubtotal(double precioNoche, int noches) => precioNoche * noches;
        static double CalcularDescuento(double subtotal, int noches) => (noches >= 5) ? subtotal * 0.15 : 0;
        static double CalcularImpuesto(double subtotal) => subtotal * 0.10;
    }
}
