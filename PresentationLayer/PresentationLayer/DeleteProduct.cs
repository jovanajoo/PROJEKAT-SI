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
    public partial class DeleteProduct : Form
    {
        private readonly ProductBusiness productBusiness;
        public DeleteProduct()
        {
            this.productBusiness = new ProductBusiness();
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            List<Shared.Models.Product> products = this.productBusiness.GetAllProducts();
            foreach (Shared.Models.Product p in products)
            {
                bunifuDropdownById.Items.Add(p.ProductID);
            }
        }

        private void bunifuDropdownById_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared.Models.Product p = this.productBusiness.GetProductsById(Convert.ToInt32(bunifuDropdownById.Text));

            bunifuTextBoxName.Text = p.Name;
            bunifuTextBoxPrice.Text = Convert.ToString(p.Price);
            bunifuTextBoxSize.Text = Convert.ToString(p.Size);
            bunifuTextBoxDescription.Text = p.Description;
            bunifuTextBoxCategoryId.Text = Convert.ToString(p.CategoryID);
        }

        private void bunifuButtonDelete_Click(object sender, EventArgs e)
        {
            if (bunifuDropdownById == null)
            {
                MessageBox.Show("Select id !");
            }
            else
            {
                int id = Convert.ToInt32(bunifuDropdownById.Text);
                if (this.productBusiness.DeleteProductsById(id))
                {
                    MessageBox.Show("Product is deleted!");

                    List<Shared.Models.Product> products = this.productBusiness.GetAllProducts();
                    bunifuDropdownById.Items.Clear();
                    foreach (Shared.Models.Product p in products)
                    {
                        bunifuDropdownById.Items.Add(p.ProductID);
                    }
                    bunifuTextBoxName.Text = "";
                    bunifuTextBoxPrice.Text = "";
                    bunifuTextBoxSize.Text = "";
                    bunifuTextBoxDescription.Text = "";
                    bunifuTextBoxCategoryId.Text = "";
                }
                else
                {
                    MessageBox.Show("Select Id !");
                }
            }
        }
    }
}
