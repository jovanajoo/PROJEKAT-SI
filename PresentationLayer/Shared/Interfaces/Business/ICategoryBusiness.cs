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
        bool InsertCategories(Category c);
        bool DeleteCategoriesById(int CategoriesID);
        Category GetCategoriesById(int Id);
        bool UpdateCategoriesById(Category c);
    }
}
