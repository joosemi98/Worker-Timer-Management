using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO
{
    public partial class Form1GestionPedidos : Form
    {
        public Form1GestionPedidos()
        {
            InitializeComponent();  ////
            txtNumPedido.Text = String.Format("{0:D4}", Pedido.numeroPedidoSecuencia); ; // Formato "00001"
        }

        private void timerRelojTick_Tick(object sender, EventArgs e)
        {
            label1Time.Text = DateTime.Now.ToString("HH:mm:ss"); // Examen 

        }

        private void comboBox1NomDescrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            Producto producte = new Producto(cmbNomDescrip.SelectedItem.ToString(), int.Parse(txtPrecioProducto.Text), int.Parse(nudCanti.Value.ToString()));
            txtPrecioProducto.Text = producte.PrecioUnit.ToString();
        }

        private void button1AnadirProducto_Click(object sender, EventArgs e)
        {
            int indiceNewProducto = Datos.IndexdiProducto(cmbNomDescrip.Text);
            if (indiceNewProducto == -1)
            {
                if (Datos.Products.Count < 3)
                {

                    Datos.Products.Add(new Producto(cmbNomDescrip.Text, int.Parse(txtPrecioProducto.Text), int.Parse(nudCanti.Value.ToString())));
                    MessageBox.Show("Producto añadido con éxito!");
                }
                else
                {
                    MessageBox.Show("Elimina almenos un producto para añadir otro");
                }
            }
            else
            {
                Datos.Products[indiceNewProducto].Cantidad += int.Parse(nudCanti.Value.ToString());
            }
            RestaurarGrid();
        }


        private void RestaurarGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (Producto producto in Datos.Products)
            {
                dataGridView1.Rows.Add(producto.Cantidad, producto.Descripcion, producto.PrecioUnit, Pedido.CalculoImporte(producto.PrecioUnit, producto.Cantidad));
            }
            label1PrecioTotal.Text = Pedido.CalculoImporteTotalPedido(Datos.Products).ToString();
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult d = MessageBox.Show("¿Deseas eliminar el producto seleccionado?", "ALERTA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Datos.Products.RemoveAt(e.RowIndex);
                RestaurarGrid();

                MessageBox.Show("Producto eliminado con éxito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void VaciarCampos()
        {
            txtNIF.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";

        }

        private void btnRegistrarPedido_Click(object sender, EventArgs e)
        {
            Pedido p = new Pedido(txtNIF.Text, txtNombre.Text, txtDireccion.Text, Pedido.CalculoImporteTotalPedido(Datos.Products), Datos.Products);
            dataGridView2.Rows.Add(String.Format("{0:D4}", p.NumeroPedido), p.NIFCliente, p.FechaRegistro, Datos.Products.Count, Pedido.CalculoImporteTotalPedido(Datos.Products));
            Datos.Pedidos.Clear();
            VaciarCampos();
            Datos.Pedidos.Add(p);
            RestaurarGrid();
            txtNumPedido.Text = String.Format("{0:D4}", Pedido.numeroPedidoSecuencia);
            MessageBox.Show("Pedido registrado con éxito");
        }

        private void button3Guardar_Click(object sender, EventArgs e)
        {
            StreamWriter txtwrite = new StreamWriter("pedido.txt");
            foreach (Pedido pedido in Datos.Pedidos)
            {
                txtwrite.WriteLine($"Nº{pedido.NumeroPedido};NIF:{pedido.NIFCliente};Fecha:{pedido.FechaRegistro}");
                MessageBox.Show("Pedidos guardados en pedido.txt");
            }
            txtwrite.Close();
        }

        private void comboBox1NomDescrip_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtPrecioProducto.Text = Producto.DevolverPrecio(cmbNomDescrip.Text).ToString();
        }
    }
}
















