using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWin2
{
    public partial class Proye : Form
    {
        public Proye()
        {
            InitializeComponent();
        }


        NorwinDataContext northwind = new NorwinDataContext();


        private void button12_Click(object sender, EventArgs e)
        {
            Form1 par = new Form1();
            par.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var consulta = from All in northwind.Employees
                           select All;
            dgvDatos.DataSource = consulta;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Mostrar proyeccion de las clases
            //Proyeccion: Mostrar ciertas columnas requeridas
            var query = from C in northwind.Employees
                        select new
                        {
                            NombreCompelto = C.FirstName + " " + C.LastName,
                            C.City,
                            C.Region,
                            C.PostalCode
                        };
            dgvDatos.DataSource = query;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var query = from All in northwind.Categories
                        select All;
            dgvDatos.DataSource = query;
        }


        //Proyeccion
        private void button8_Click(object sender, EventArgs e)
        {
            string search = txt1.Text;

            var query = from C in northwind.Categories
                        where C.CategoryName == search
                        select new
                        {
                            C.CategoryID,
                            C.CategoryName,
                            C.Description,
                            
                        };

            dgvDatos.DataSource = query;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int search = int.Parse(txt1.Text);

            var query = from C in northwind.Categories
                        where C.CategoryID == search
                        select new
                        {
                            C.CategoryID,
                            C.CategoryName,
                            C.Description
                        };

            dgvDatos.DataSource = query;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var query = from All in northwind.Products
                        select All;
            dgvDatos.DataSource = query;
        }
        //Proyeccion
        private void button4_Click(object sender, EventArgs e)
        {

            int search = int.Parse(txtBusqueda.Text);

            var query = from C in northwind.Products
                        where C.SupplierID == search
                        select new
                        {
                            C.ProductName,
                            inversion = "S/. " + C.UnitPrice * C.UnitsInStock
                        };

            dgvDatos.DataSource = query;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string search = txtBusqueda.Text;

            var query = from C in northwind.Products
                        where C.ProductName == search
                        select new
                        {
                            C.ProductName,
                            Stok = C.UnitsInStock,
                            inversion = "S/. " + C.UnitPrice * C.UnitsInStock
                        };

            dgvDatos.DataSource = query;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var query = from All in northwind.Suppliers
                        select All;
            dgvDatos.DataSource = query;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string search = txt3.Text;

            var query = from C in northwind.Suppliers
                        where C.CompanyName == search
                        select new
                        {
                            Nombre = C.ContactName,
                            Cargo_en_la_empresa = C.ContactTitle,
                            direccion = "Pais: " + C.Country + "- Ciudad: " + C.City + "- codigo Postal: " + C.PostalCode,
                            C.Fax,
                            C.Phone

                        };

            dgvDatos.DataSource = query;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string search = txt3.Text;

            var query = from C in northwind.Suppliers
                        where C.Country == search || C.CompanyName == search

                        select new
                        {
                            C.CompanyName,
                            C.HomePage

                        };

            dgvDatos.DataSource = query;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //lambda
            //buscar productos por nombre
            string search1 = txt1.Text;
            var query = northwind.Products.Where(B => B.ProductName == search1);
            dgvDatos.DataSource = query;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            //lambda
            //buscar orden por fecha de pedido
            string search = txt1.Text;
            string search2 = txtBusqueda.Text;
            DateTime dt = DateTime.ParseExact(search, "yyyy", provider);
            //DateTime dt2 = DateTime.ParseExact(search, "MM", CultureInfo.InvariantCulture);



            var query = northwind.Orders
                .Where(b => b.OrderDate == dt);
            dgvDatos.DataSource = query;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //lambda
            //buscar producto por unidades de stok
            int search = int.Parse(txt1.Text);

            var query = northwind.Products
                .Where(b => b.UnitsInStock == search);

            dgvDatos.DataSource = query;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //lambda
            //buscar pedido por fecha de pedido año y mes + pais de envio
            string search = txt1.Text;
            string search2 = txtBusqueda.Text;
            DateTime dt = DateTime.ParseExact(search, "yyyy", CultureInfo.InvariantCulture);


            var query = northwind.Orders
                .Where(b => b.ShipCountry == search2 & b.OrderDate == dt);
            dgvDatos.DataSource = query;

        }
    }
}
