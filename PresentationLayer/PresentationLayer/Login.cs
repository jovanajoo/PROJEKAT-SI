using BusinessLayer;
using DataAccessLayer.Models;
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
    public partial class Login : Form
    {
        private readonly CustomerBusiness customerBusiness;
        public Login()
        {
            this.customerBusiness = new CustomerBusiness();
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (bunifuTextBoxUsername.Text.Length != 0 && bunifuTextBoxPassword.Text.Length != 0)
            {
                Customer c = customerBusiness.GetCustomersByUserAndPass(bunifuTextBoxUsername.Text, bunifuTextBoxPassword.Text);
                if (c != null)
                {
                    MessageBox.Show("You have successfully logged in");
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");

                }
            }
            else
            {
                MessageBox.Show("Enter username or password!");
            }
        }
    }
}
