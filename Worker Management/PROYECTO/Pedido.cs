using PROYECTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO
{
    public class Pedido
    {
        public static int numeroPedidoSecuencia = 1;
        private int numeroPedido;
        private string nIFCliente;
        private string nombreCliente;
        private string direccion;
        private DateTime fechaRegistro;
        private List<Producto> productos;
        private double importeTotal;


        public List<Producto> Productos { get { return productos; } }
        public int NumeroPedido { get { return numeroPedido; } }
        public string NIFCliente { get { return nIFCliente; } }
        public string NombreCliente { get { return nombreCliente; }  }
        public string Direccion { get { return direccion; } }
        public DateTime FechaRegistro { get { return fechaRegistro; } }


        public Pedido(string niFclie, string nomClie, string dire, double importeTot, List<Producto> products)
        {
            this.numeroPedido = numeroPedidoSecuencia;
            this.nIFCliente = niFclie;
            this.nombreCliente = nomClie;
            this.direccion = dire;
            this.fechaRegistro = DateTime.Now;
            this.productos = products;
            this.importeTotal = importeTot;
            

            numeroPedidoSecuencia += 1;
        }
        public static int CalculoImporte(int precio, int cantidad)
        {
            return precio * cantidad;
        }

        public static int CalculoImporteTotalPedido(List<Producto> lista)
        {
            int ImporteTotal = 0;
            foreach (Producto producto in lista)
            {
                ImporteTotal += CalculoImporte(producto.PrecioUnit, producto.Cantidad);
            }

            return ImporteTotal;
        }

    }
}
