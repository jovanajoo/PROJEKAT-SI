using BusinessLayer;
using Shared.Interfaces.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class AddProduct : Form
    {
        private readonly IProductBusiness productBusiness;
        public AddProduct(IProductBusiness _productBusiness)
        {
            this.productBusiness = _productBusiness;
            InitializeComponent();
        }
        
        private void AddProduct_Load(object sender, EventArgs e)
        {
            List<Shared.Models.Product> results = this.productBusiness.GetAllProducts();
            bunifuDataGridView1.Columns["ID"].DataPropertyName = "ProductID";
            bunifuDataGridView1.Columns["ProductName"].DataPropertyName = "Name";
            bunifuDataGridView1.Columns["Price"].DataPropertyName = "Price";
            bunifuDataGridView1.Columns["Size"].DataPropertyName = "Size";
            bunifuDataGridView1.Columns["Description"].DataPropertyName = "Description";
            bunifuDataGridView1.Columns["CategoryID"].DataPropertyName = "CategoryId";
            bunifuDataGridView1.AutoGenerateColumns = false;
            bunifuDataGridView1.DataSource = results;
        }
        Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }

        }
        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void bunifuButtonUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    lblFileName.Text = openFile.FileName;
                    pictureBox1.Image = Image.FromFile(lblFileName.Text);
                }
            }
        }

        private void bunifuButtonSaveData_Click(object sender, EventArgs e)
        {
        Shared.Models.Product p = new Shared.Models.Product();
            try
            {
                p.Name = bunifuTextBoxName.Text;
                p.Price = Convert.ToDecimal(bunifuTextBoxPrice.Text);
                p.Size = Convert.ToInt32(bunifuTextBoxSize.Text);
                p.Description = bunifuTextBoxDescription.Text;
                p.CategoryID = Convert.ToInt32(bunifuTextBoxCategoryId.Text);
                p.ProductImage = ConvertImageToBinary(Image.FromFile(lblFileName.Text));
            }
            catch
            {
                MessageBox.Show("Incorrect format, try again!");
                return;
            }


            if (this.productBusiness.InsertProducts(p))
            {

                bunifuTextBoxName.Text = "";
                bunifuTextBoxPrice.Text = "";
                bunifuTextBoxSize.Text = "";
                bunifuTextBoxDescription.Text = "";
                bunifuTextBoxCategoryId.Text = "";
                pictureBox1.Image = null;
                bunifuDataGridView1.DataSource = this.productBusiness.GetAllProducts();

                MessageBox.Show("Successfully save data");
            }
            else
            {
                MessageBox.Show("Eror!");
            }
        }
    }
}
