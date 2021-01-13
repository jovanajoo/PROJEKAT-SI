using BusinessLayer;
using Shared.Interfaces.Business;
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
        private readonly IProductBusiness productBusiness;
        private readonly ICustomerBusiness customerBusiness;
       
        public Form1(IProductBusiness _productBusiness, ICustomerBusiness _customersBusiness)
        {
            this.productBusiness = _productBusiness;
            this.customerBusiness = _customersBusiness;
            InitializeComponent();
        }

        private void bunifuButtonRegistration_Click(object sender, EventArgs e)
        {
            Registration rg = new Registration(this.customerBusiness, this.productBusiness);
            rg.ShowDialog();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct(this.productBusiness);
            ap.ShowDialog();
        }

        private void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteProduct dp = new DeleteProduct(this.productBusiness);
            dp.ShowDialog();
        }

        private void bunifuButtonLogin_Click_1(object sender, EventArgs e)
        {
            Login lg = new Login(this.customerBusiness, this.productBusiness);
            lg.ShowDialog();
        }

        private void updateProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateProduct up = new UpdateProduct(this.productBusiness);
            up.ShowDialog();
        }
    }
}
