using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductsBusiness
    {
        public ProductRepository productsRepository;
        public ProductsBusiness()
        {
            this.productsRepository = new ProductRepository();
        }

        public List<Product> getAllProducts()
        {
            return this.productsRepository.GetAllProducts();
        }



        public bool InsertProducts(Product p)
        {
            if (this.productsRepository.InsertProducts(p) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public bool deleteProductsById(int ProductID)
        {
            if (this.productsRepository.deleteProductsById(ProductID) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public Product getProductsById(int ProductID)
        {
            return this.productsRepository.GetAllProducts().Where(p => p.ProductID == ProductID).First();
        }



        public bool updateCProductsById(Product p)
        {
            if (this.productsRepository.updateCProductsById(p) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
