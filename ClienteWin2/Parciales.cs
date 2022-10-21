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
    public partial class Parciales : Form
    {
        public Parciales()
        {
            InitializeComponent();
        }
        //declarar un solo objeto  que instancie el mapeado objeto relacional
        NorwinDataContext northwind = new NorwinDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            var query = from All in northwind.Categories
                        select All;
            dgvDatos.DataSource = query;
        }

  

       //------------------------------------------------------

        private void button1_Click_1(object sender, EventArgs e)
        {
            var consulta = from All in northwind.Employees
                           select All;
            dgvDatos.DataSource = consulta;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Mostrar proyeccion de las clases
            //Proyeccion: Mostrar ciertas columnas requeridas
            var query = from C in northwind.Employees
                        select new
                        {
                            NombreCompelto = C.EConcatecado(),
                            C.City,
                            C.Region,
                            C.PostalCode
                        };
            dgvDatos.DataSource = query;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            string search = txt3.Text;

            var query = from C in northwind.Suppliers
                        where C.Country == search || C.CompanyName == search

                        select new
                        {
                            C.CompanyName,
                            C.HomePage ,

                        };

            dgvDatos.DataSource = query;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            string search = txtBusqueda.Text;

            var query = from C in northwind.Products
                        where C.ProductName == search
                        select new
                        {
                            C.ProductName,
                            Stok = C.UnitsInStock,
                            inversion = C.PUnitPUnitSt()
                        };

            dgvDatos.DataSource = query;
        }

        private void button9_Click_1(object sender, EventArgs e)
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

        private void button10_Click_1(object sender, EventArgs e)
        {
            string search = txt3.Text;

            var query = from C in northwind.Suppliers
                        where C.CompanyName == search
                        select new
                        {
                            Nombre = C.ContactName,
                            Cargo_en_la_empresa = C.ContactTitle,
                            direccion = C.SDireccion(),
                            C.Fax,
                            C.Phone

                        };

            dgvDatos.DataSource = query;

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int search = int.Parse(txtBusqueda.Text);

            var query = from C in northwind.Products
                        where C.SupplierID == search
                        select new
                        {
                            C.ProductName,
                            inversion = C.PUnitPUnitSt()
                        };

            dgvDatos.DataSource = query;

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            string search = txt1.Text;

            var query = from C in northwind.Categories
                        where C.CategoryName == search
                        select new
                        {
                            C.CategoryID,
                            Category = C.Cate(),
                            C.Description
                        };

            dgvDatos.DataSource = query;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            var query = from All in northwind.Products
                        select All;
            dgvDatos.DataSource = query;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            var query = from All in northwind.Suppliers
                        select All;
            dgvDatos.DataSource = query;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form1 par = new Form1();
            par.Show();
            this.Hide();
        }
    }
}