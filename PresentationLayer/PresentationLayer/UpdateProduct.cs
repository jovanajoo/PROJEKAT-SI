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
    public partial class UpdateProduct : Form
    {
        private readonly ProductBusiness productBusiness;
        public UpdateProduct()
        {
            this.productBusiness = new ProductBusiness();
            InitializeComponent();
        }
        private void UpdateProduct_Load(object sender, EventArgs e)
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

        private void bunifuButtonUpdate_Click(object sender, EventArgs e)
        {
           
                if(bunifuDropdownById.SelectedIndex == -1)
                {
                    MessageBox.Show("Select Id !");
                }
                else
                {
                    int id = Convert.ToInt32(bunifuDropdownById.Text);
                    Shared.Models.Product p = new Shared.Models.Product();
                    p.Name = bunifuTextBoxName.Text;
                    p.Price = Convert.ToDecimal(bunifuTextBoxPrice.Text);
                    p.Size = Convert.ToInt32(bunifuTextBoxSize.Text);
                    p.Description = bunifuTextBoxDescription.Text;
                    p.CategoryID = Convert.ToInt32(bunifuTextBoxCategoryId.Text);

                    this.productBusiness.UpdateCProductsById(p);
                    MessageBox.Show("Product is updated");
                }
          

        }
    }
}
