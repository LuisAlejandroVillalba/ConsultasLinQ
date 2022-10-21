using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWin2
{
    public partial class Join : Form
    {
        public Join()
        {
            InitializeComponent();
        }
        NorwinDataContext north = new NorwinDataContext();



        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 par = new Form1();
            par.Show();
            this.Hide();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {

            var id = int.Parse(txtID.Text);

            var consulta = from ca in north.Categories
                           join p in north.Products
                           on ca.CategoryID equals id
                           select new
                           {
                               Produto = p.ProductName,
                               Categoria = ca.CategoryName,
                               IDCategoria = ca.CategoryID,
                           };


            dgvDatos.DataSource = consulta;

        }

        // Esta funcion recibe como parametro un nombre para poder listar todos los productos de cierto
        // proveedor
        private void btnProveedor_Click(object sender, EventArgs e)
        {
            var nombre = txtProveedor.Text;

            var consulta = from s in north.Suppliers
                           join p in north.Products
                           on s.CompanyName equals nombre
                           select new
                           {
                               NombreCompania = s.CompanyName,
                               NombreContacto = s.ContactName,
                               NombreProducto = p.ProductName,
                               IDProducot = p.ProductID,
                           };

            dgvDatos.DataSource = consulta;
        }


        // Esta funcion recibe como parametro el nombre del producto para poder listar los detalles del producto
        private void btnOrden_Click(object sender, EventArgs e)
        {
            var producto = int.Parse(txtIDProducto.Text);

            var consulta = from p in north.Products
                           join d in north.Order_Details
                           on p.ProductID equals producto
                           select new
                           {
                               IDOrden = d.OrderID,
                               NombreProducto = p.ProductName,
                               PrecioUnidad = d.UnitPrice,
                               Cantidad = d.Quantity,
                               Descuento = d.Discount,
                           };

            dgvDatos.DataSource = consulta;
        }

        // Esta funcion recibe un nombre como parametro para poder listar los productos vendidos por 
        // dicho empleado
        private void Empleado_Click(object sender, EventArgs e)
        {
            var empleado = txtEmpleado.Text;

            var consulta = from en in north.Employees
                           join o in north.Orders
                           on en.FirstName equals empleado
                           select new
                           {
                               NombreEmpleado = en.FirstName,
                               IdOrden = o.OrderID,
                               Fecha = o.OrderDate,
                               DireccionEnvio = o.ShipAddress,
                               CiudadEnvio = o.ShipCity,
                           };

            dgvDatos.DataSource = consulta;
        }
    }
}
