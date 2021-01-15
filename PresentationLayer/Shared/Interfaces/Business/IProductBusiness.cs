using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IProductBusiness
    {
        List<Product> GetAllProducts();
        bool InsertProducts(Product p);
        bool DeleteProductsById(int ProductID);
        Product GetProductsById(int ProductID);
        bool UpdateCProductsById(Product p);
    }
}
