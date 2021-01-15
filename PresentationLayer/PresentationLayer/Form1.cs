using BusinessLayer;
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

    public partial class Form1 : Form
    {
        private readonly IProductBusiness productBusiness;
        private readonly ICustomerBusiness customerBusiness;
        private readonly IOrderBusiness orderBusiness;
        private readonly IOrder_ItemBusiness order_ItemBusiness;
       
        public Form1(IProductBusiness _productBusiness, ICustomerBusiness _customersBusiness, IOrderBusiness _orderBusiness, IOrder_ItemBusiness _order_ItemBusiness)
        {
            this.productBusiness = _productBusiness;
            this.customerBusiness = _customersBusiness;
            this.orderBusiness = _orderBusiness;
            this.order_ItemBusiness = _order_ItemBusiness;
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
        public static Customer currentCustomer;
        private Order o;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            o = new Order()
            {
                Order_Date = DateTime.Now,
                Delivery_Date = DateTime.Now.AddDays(3),
                CustomerID = 1
            };
            this.orderBusiness.InsertOrders(o);
            o.OrderID = this.orderBusiness.GetNewOrder();
            List<Shared.Models.Product> lista = this.productBusiness.GetAllProducts();
           
            bunifuDataGridViewProducts.Columns["ID"].DataPropertyName = "ProductID";
            bunifuDataGridViewProducts.Columns["ProductName"].DataPropertyName = "Name";
            bunifuDataGridViewProducts.Columns["Price"].DataPropertyName = "Price";
            bunifuDataGridViewProducts.Columns["Size"].DataPropertyName = "Size";
            bunifuDataGridViewProducts.Columns["Description"].DataPropertyName = "Description";
            bunifuDataGridViewProducts.AutoGenerateColumns = false;
            bunifuDataGridViewProducts.DataSource = lista;
            
        }
        int n = 0;
        decimal GrdTotal = 0;

        private void bunifuDataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bunifuTextBoxProduct.Text = bunifuDataGridViewProducts.SelectedRows[0].Cells[1].Value.ToString();
            bunifuTextBoxPrice.Text = bunifuDataGridViewProducts.SelectedRows[0].Cells[2].Value.ToString();
            bunifuTextBoxProductId.Text = bunifuDataGridViewProducts.SelectedRows[0].Cells[0].Value.ToString();
        }
        
        private void bunifuButtonAddToBill_Click(object sender, EventArgs e)
        {
            int n = 0;
            decimal GrdTotal = 0;

            if (bunifuTextBoxQuantity.Text == "" || bunifuTextBoxPrice.Text == "")
            {
                MessageBox.Show("Enter The Quanitiy!");
            }
            else
            {
               
                if(currentCustomer != null)
                {
                    decimal total = Convert.ToInt32(bunifuTextBoxQuantity.Text) * Convert.ToDecimal(bunifuTextBoxPrice.Text); ;
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(bunifuDataGridViewBill);
                    newRow.Cells[0].Value = n + 1;
                    newRow.Cells[1].Value = bunifuTextBoxProduct.Text;
                    newRow.Cells[2].Value = bunifuTextBoxPrice.Text;
                    newRow.Cells[3].Value = bunifuTextBoxQuantity.Text;
                    newRow.Cells[4].Value = total;
                    bunifuDataGridViewBill.Rows.Add(newRow);
                    n++;
                    GrdTotal += total;
                    labelAmount.Text = "" + GrdTotal;
                    o.CustomerID = currentCustomer.CustomerID;
                    Order_Item oi = new Order_Item()
                    {
                        OrderID = o.OrderID,
                        ProductID = Convert.ToInt32(bunifuTextBoxProductId.Text),
                        Quantity = Convert.ToInt32(bunifuTextBoxQuantity.Text)
                        
                    };
                    this.order_ItemBusiness.InsertOrderItems(oi);
                }
                else
                {
                    MessageBox.Show("Please log in ! ");
                }
               
            }
        }

        private void bunifuButtonBuy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for buying ! See agin");
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(bunifuDataGridViewBill.Rows.Count == 0)
            {
                this.orderBusiness.DeleteOrdersById(o.OrderID);
            }
        }
    }
   
}
