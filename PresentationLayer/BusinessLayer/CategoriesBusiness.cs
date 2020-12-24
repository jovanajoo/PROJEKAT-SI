using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CategoriesBusiness
    {
        public CategoriesRepository categoriesRepository;
        public CategoriesBusiness()
        {
            this.categoriesRepository = new CategoriesRepository();
        }

        public List<Categories> getAllCategories()
        {
            return this.categoriesRepository.GetAllCategories();
        }



        public bool InsertCategories(Categories c)
        {
            if (this.categoriesRepository.InsertCategories(c) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public bool deleteCategoriesById(int CategoriesID)
        {
            if (this.categoriesRepository.deleteCategoriesById(CategoriesID) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public Categories getCategoriesById(int Id)
        {
            return this.categoriesRepository.GetAllCategories().Where(c => c.CategoryID == Id).First();
        }



        public bool updateCategoriesById(Categories c)
        {
            if (this.categoriesRepository.updateCategoriesById(c) > 0)
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
