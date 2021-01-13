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
    public partial class Registration : Form
    {
        private readonly ICustomerBusiness customerBusiness;
        private readonly IProductBusiness productBusiness;
        public Registration(ICustomerBusiness _customerBusiness, IProductBusiness _productBusiness)
        {
            this.customerBusiness = _customerBusiness;
            this.productBusiness = _productBusiness;
            InitializeComponent();
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void bunifuButtonRegistration_Click(object sender, EventArgs e)
        {
            if (CheckTextBox())
            {

                Customer c = new Customer()
                {
                    Username = bunifuTextBoxUserName.Text,
                    Name = bunifuTextBoxNameS.Text,
                    Email = bunifuTextBoxEmail.Text,
                    City = bunifuTextBoxCity.Text,
                    Address = bunifuTextBoxAddress.Text,
                    PhoneNumber = bunifuTextBoxPhone.Text,
                    Password = bunifuTextBoxPassword.Text
                };

                if (this.customerBusiness.InsertCustomers(c))
                {
                    MessageBox.Show("Uspesna registracija");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Greska");
                }
            }
        }
        private bool CheckTextBox()
        {
            TextBox tb = this.Controls.OfType<TextBox>().FirstOrDefault(c => c.Text.Length == 0);
            if (tb != null)
            {
                tb.Focus();
                MessageBox.Show("Popunite sva polja");
                return false;
            }
            return true;
        }

        private void bunifuButtonL_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login(this.customerBusiness, this.productBusiness);
            lg.ShowDialog();
        }
    }
}
