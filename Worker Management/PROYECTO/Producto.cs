using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO
{
    public class Producto
    {
        private string descripcion;
        private int precioUnit;
        private int cantidad;

        public int PrecioUnit { get { return precioUnit; } }
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }
        public string Descripcion { get { return descripcion; } }  



        public Producto(string descripcion, int precio,int cantidad)
        {
            this.descripcion = descripcion;
            this.precioUnit = precio;
            this.cantidad = cantidad;
        }

        public static int DevolverPrecio(string desc)
        {
            int precio = 0;
            switch (desc)
            {
                case "PS4Y2MANDOSDS4":
                    precio = 2000;
                    break;
                case "PS4Y1MANDOSDS4":
                    precio = 1800;
                    break;
                case "PS3":
                    precio = 1350;
                    break;
                case "MANDOPS4DS4":
                    precio = 250;
                    break;
                case "MANDOPS3DS4":
                    precio = 175;
                    break;
                default:
                    Console.WriteLine("Descripción no encontrada.");
                    break;
            }
            return precio;
        }
    }
}
