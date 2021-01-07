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
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {  
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Categories";

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Category c = new Category();
                    c.CategoryID = sqlDataReader.GetInt32(0);
                    c.Name = sqlDataReader.GetString(1);
                    c.Description = sqlDataReader.GetString(2);

                    results.Add(c);
                }
            }
            return results;
        }
        public int InsertCategories(Category c)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                    string.Format("INSERT INTO Categories VALUES('{0}', '{1}')",
                    c.Name, c.Description);
                return sqlCommand.ExecuteNonQuery();
            }
        }
        public int DeleteCategoriesById(int CategoriesID)
        {
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                string.Format("DELETE FROM Categories WHERE CatgeoriesID = {0}", CategoriesID);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();

            }
        }
        public Category GetCategoriesById(int Id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {

    
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                string.Format(" SELECT * FROM Categories WHERE Id = {0}", Id);

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                sqlDataReader.Read();
                Category c = new Category();
                c.CategoryID = sqlDataReader.GetInt32(0);
                c.Name = sqlDataReader.GetString(1);
                c.Description = sqlDataReader.GetString(2);
            

                return c;
            }
        }

        public int UpdateCategoriesById(Category c)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                string.Format(" UPDATE Categories SET Name = '{0}', Description = '{1}', WHERE CategoryId={2}", c.Name, c.Description);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }







    }
}
