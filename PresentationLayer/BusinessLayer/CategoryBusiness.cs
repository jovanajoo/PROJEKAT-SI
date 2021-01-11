﻿using DataAccessLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CategoryBusiness
    {
        public CategoryRepository categoryRepository;
        public CategoryBusiness()
        {
            this.categoryRepository = new CategoryRepository();
        }

        public List<Category> GetAllCategories()
        {
            return this.categoryRepository.GetAllCategories();
        }

        public bool InsertCategories(Category c)
        {
            if (this.categoryRepository.InsertCategories(c) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public bool DeleteCategoriesById(int CategoriesID)
        {
            if (this.categoryRepository.DeleteCategoriesById(CategoriesID) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public Category GetCategoriesById(int Id)
        {
            return this.categoryRepository.GetAllCategories().Where(c => c.CategoryID == Id).First();
        }



        public bool UpdateCategoriesById(Category c)
        {
            if (this.categoryRepository.UpdateCategoriesById(c) > 0)
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
