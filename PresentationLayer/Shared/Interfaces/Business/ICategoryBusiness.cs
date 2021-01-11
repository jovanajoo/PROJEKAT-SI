using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface ICategoryBusiness
    {
        List<Category> GetAllCategories();
        int InsertCategories(Category c);
        int DeleteCategoriesById(int CategoriesID);
        Category GetCategoriesById(int Id);
        int UpdateCategoriesById(Category c);
    }
}
