using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresupuestoMuebles
{
    public partial class Form1 : Form
    {
        Presupuesto presupuesto;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnIniciarPresp_Click(object sender, EventArgs e)
        {
            string cliente = tbNombre.Text;
            string dir = tbDireccion.Text;

            presupuesto = new Presupuesto(cliente, dir);

            gbProducto.Visible = true;

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double precioBase = Convert.ToDouble(tbPrecioB.Text);
            double largo = Convert.ToDouble(tbLargo.Text);

            int codigo = Convert.ToInt32(tbCodigo.Text);

            Producto nuevo = null;

            if(string.IsNullOrWhiteSpace(tbAncho.Text) && string.IsNullOrWhiteSpace(tbGrosor.Text))
            {
                nuevo = new Banco(precioBase, largo);
                nuevo.Codigo = codigo;
               
            }
            else
            {
                double ancho = Convert.ToDouble(tbAncho.Text);
                double grosor = Convert.ToDouble(tbGrosor.Text);
                nuevo = new Mesa(precioBase, largo, ancho, grosor);
                nuevo.Codigo = codigo;
                
            }

            if(presupuesto != null)
            {
                if(nuevo!=null)
                {
                    presupuesto.AgregarProducto(nuevo);

                    cmbProductos.Items.Add(codigo);
                }
            }
            


        }

        
    }
}
