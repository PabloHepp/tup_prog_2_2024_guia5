using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoMuebles
{
    abstract class Producto:IComparable
    {
        protected double precioBase;
        protected double largo;
        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public Producto (double precio, double larg)
        {
            precioBase = precio;
            largo = larg;
        }

        abstract public double Peso();

        abstract public double Precio();

        public override string ToString()
        {
            return codigo.ToString();
        }

        public int CompareTo(object ob)
        {
            Producto otro = ob as Producto;
            if(otro != null)
            {
                return codigo.CompareTo(otro.codigo);
            }
            return 1;
        }



    }
}
