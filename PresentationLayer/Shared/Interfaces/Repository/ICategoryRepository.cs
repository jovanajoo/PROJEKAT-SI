using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();
        int InsertCategories(Category c);
        int DeleteCategoriesById(int CategoriesID);
        int UpdateCategoriesById(Category c);



    }
}
