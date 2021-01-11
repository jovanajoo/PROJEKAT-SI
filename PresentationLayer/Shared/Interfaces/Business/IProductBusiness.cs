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
        int InsertProducts(Product p);
        int DeleteProductsById(int ProductID);
        Product GetProductsById(int ProductID);
        int UpdateCProductsById(Product p);
    }
}
