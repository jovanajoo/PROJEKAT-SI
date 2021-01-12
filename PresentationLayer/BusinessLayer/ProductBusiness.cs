﻿using DataAccessLayer;
using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductBusiness : IProductBusiness
    {
        public ProductRepository productRepository;
        public ProductBusiness()
        {
            this.productRepository = new ProductRepository();
        }

        public List<Product> GetAllProducts()
        {
            return this.productRepository.GetAllProducts();
        }

        public bool InsertProducts(Product p)
        {
            if (this.productRepository.InsertProducts(p) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public bool DeleteProductsById(int ProductID)
        {
            if (this.productRepository.DeleteProductsById(ProductID) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public Product GetProductsById(int ProductID)
        {
            return this.productRepository.GetAllProducts().Where(p => p.ProductID == ProductID).First();
        }



        public bool UpdateCProductsById(Product p)
        {
            if (this.productRepository.UpdateCProductsById(p) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        int IProductBusiness.InsertProducts(Product p)
        {
            throw new NotImplementedException();
        }

        int IProductBusiness.DeleteProductsById(int ProductID)
        {
            throw new NotImplementedException();
        }

        int IProductBusiness.UpdateCProductsById(Product p)
        {
            throw new NotImplementedException();
        }
    }
}
