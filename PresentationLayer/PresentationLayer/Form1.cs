using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{

    public partial class Form1 : Form
    {
        private readonly ProductBusiness productBusiness;
        public Form1()
        {
            this.productBusiness = new ProductBusiness();
            InitializeComponent();
        }

        private void bunifuButtonRegistration_Click(object sender, EventArgs e)
        {
            Registration rg = new Registration();
            rg.ShowDialog();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct();
            ap.ShowDialog();
        }

        private void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteProduct dp = new DeleteProduct();
            dp.ShowDialog();
        }

        private void bunifuButtonLogin_Click_1(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.ShowDialog();
        }
    }
}
