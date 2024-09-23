using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoMuebles
{
    internal class Mesa:Producto
    {
        private double ancho;
        private double grosor;

        public Mesa (double precio, double largo, double an, double gros):base(precio, largo)
        {
            ancho = an;
            grosor = gros;
        }

        public override double Peso()
        {
            return ((largo * ancho * grosor) * 0.3);
        }

        public override double Precio()
        {
            return (Peso() * precioBase) * 1.25;
        }

    }
}
