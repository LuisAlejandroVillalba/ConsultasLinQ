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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorwinDataContext norwi = new NorwinDataContext();

        private void btnListar_Click(object sender, EventArgs e)
        {
            Parciales par = new Parciales();
            par.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proye par = new Proye();
            par.Show();
            this.Hide();
        }

        private void btnjoin_Click(object sender, EventArgs e)
        {
            Join par = new Join();
            par.Show();
            this.Hide();
        }
    }
}
