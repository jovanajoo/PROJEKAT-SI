﻿using BusinessLayer;
using Shared.Interfaces.Business;
using Shared.Models;
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
        private readonly ICustomerBusiness customerBusiness;
        private readonly IProductBusiness productBusiness;
        public Login(ICustomerBusiness _customerBusiness, IProductBusiness _productBusiness)
        {
            this.customerBusiness = _customerBusiness;
            this.productBusiness = _productBusiness;
            InitializeComponent();
        }
        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (bunifuTextBoxUsername.Text.Length != 0 && bunifuTextBoxPassword.Text.Length != 0)
            {
                Customer c = customerBusiness.GetCustomersByUserAndPass(bunifuTextBoxUsername.Text, bunifuTextBoxPassword.Text);
                if (c != null)
                {
                    MessageBox.Show("You have successfully logged in");
                    Form1.currentCustomer = c;
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

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration rg = new Registration(this.customerBusiness, this.productBusiness);
            rg.ShowDialog();
        }
    }
}
