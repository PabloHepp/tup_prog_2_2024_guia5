using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoMuebles
{
    internal class Presupuesto
    {
        private ArrayList listaProductos = new ArrayList();
        public double Precio
        {
            get {
                double total = 0;
                foreach (Producto p in listaProductos)
                {
                    total += p.Precio();
                }
                return total;

                }
            set { Precio = value; }
        }

        private Cliente solicitante; 

        public Presupuesto (string nombre, string direccion)
        {
            solicitante = new Cliente(nombre, direccion);

        }

        public void AgregarProducto(Producto unproducto)
        {
            listaProductos.Add(unproducto);

        }

        /*
        private Producto BuscarProducto(int codigo)
        {
            int inf = 0;
            int sup = listaProductos.Count - 1;
            int medio = (inf + sup) / 2;

            while(inf<=sup)
            {
                Producto prueba = listaProductos[medio] as Producto;

                if (prueba == null)
                {
                    return null;
                }
                if (prueba.Codigo == codigo)
                {
                    return prueba;
                }
                else if (prueba.Codigo > codigo)
                {
                    sup = medio - 1;
                }
                else
                    inf = medio + 1;


                medio = (sup + inf) / 2;

            }

            return null;
        }
        */

        public Producto BuscarProductoFacil(int codigo)
        {
            Mesa prueva = new Mesa(1, 1, 1, 1);
            prueva.Codigo = codigo;

            listaProductos.Sort();

            int pos = listaProductos.BinarySearch(prueva);

            if(pos >= 0)
            {
                return listaProductos[pos] as Producto;
            }

            return null;

        }

        
        public bool QuitarProducto(int codigo)
        {
            Producto buscado = BuscarProductoFacil(codigo);

            if(buscado!= null)
            {
                listaProductos.Remove(buscado);
                Precio-= buscado.Precio();
                return true;
            }

            return false;
        }

        public string[] Resumen() // que bardo eeehh
        {
            String[] detalle = new string[listaProductos.Count + 2];
            int extra = 0;
            detalle[extra++] = solicitante.ToString();
            foreach (Producto p in listaProductos)
            {
                detalle[extra++] = $"{p.Codigo} -Peso: {p.Peso()} -Precio:${p.Precio():f3}";
            }

            detalle[extra++] = $"Total: ${Precio:f4}";
            return detalle;

        }
    }
}
