using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CategoryRepository
    {
        public List<Category> GetAllCategories()
        {
            List<Category> results = new List<Category>();
            SqlDataReader sqlDataReader=DBConnection.GetData("SELECT * FROM Categories");

                while (sqlDataReader.Read())
                {
                    Category c = new Category();
                    c.CategoryID = sqlDataReader.GetInt32(0);
                    c.Name = sqlDataReader.GetString(1);
                    c.Description = sqlDataReader.GetString(2);

                    results.Add(c);
                }
         
            return results;
        }
        public int InsertCategories(Category c)
        {
            var result = DBConnection.EditData(string.Format("INSERT INTO Categories VALUES('{0}', '{1}')",
                    c.Name, c.Description));
            DBConnection.CloseConnection();
            return result;
        }
        public int DeleteCategoriesById(int CategoriesID)
        {
            var result = DBConnection.EditData(string.Format("DELETE FROM Categories WHERE CatgeoriesID = {0}", CategoriesID));

            DBConnection.CloseConnection();
            return result;

        }
        
        public int UpdateCategoriesById(Category c)
        {
            var result = DBConnection.EditData(string.Format(" UPDATE Categories SET Name = '{0}', Description = '{1}', WHERE CategoryId={2}", c.Name, c.Description));

            DBConnection.CloseConnection();
            return result;
        }







    }
}
