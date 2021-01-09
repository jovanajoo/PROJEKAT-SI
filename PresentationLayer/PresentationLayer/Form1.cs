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

        private void bunifuButtonLogin_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.ShowDialog();
        }

        private void bunifuButtonRegistration_Click(object sender, EventArgs e)
        {
            Registration rg = new Registration();
            rg.ShowDialog();
        }
    }
}
