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
            get { return Precio; }
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
                return true;
            }

            return false;
        }
        

    }
}
