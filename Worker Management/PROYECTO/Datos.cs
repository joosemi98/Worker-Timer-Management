using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO
{
    internal class Datos
    {

        private static List<Producto> products = new List<Producto>();
        private static List<Pedido> pedidos = new List<Pedido>();

        public static List<Producto> Products { get { return products; } set { products = value; } }
        public static List<Pedido> Pedidos { get { return pedidos; } set { pedidos = value; } }

        public static int IndexdiProducto(string nombreProducto)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (products[i].Descripcion == nombreProducto)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
