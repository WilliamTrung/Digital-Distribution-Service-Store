using DigitalDistributionStoreWinApp;
using Microsoft.Data.SqlClient;
using Product;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace DigitalDistributionStoreLibrary.DataAccess
{
    public class CategoryDAO
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dataReader;

        private static CategoryDAO instance = null;
        private static readonly object instanceLock = new object();
        private CategoryDAO() {}
        public static CategoryDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if(instance == null)
                    {
                        instance = new CategoryDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Category> GetCatagories()
        {
            List<Category> List = new List<Category>();
            String sql = "SELECT categoryId, categoryName FROM tblCategories";
            connection = new SqlConnection(DBInteraction.GetConnectionString());
            command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                dataReader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        int categoryId = (Int32)dataReader["categoryId"];
                        string categoryName = (string)dataReader["categoryName"];
                        Category category = new Category(categoryId,categoryName);
                        List.Add(category);
                    }
                }
                else
                {
                    throw new Exception("No record found!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            } 
            finally
            {
                connection.Close();
            }
            return List;
        }
        public Boolean InsertCategory(Category category)
        {
            Boolean check = false;
            connection = new SqlConnection(DBInteraction.GetConnectionString());
            command = new SqlCommand("INSERT INTO tblCategories VALUES(@categoryName)", connection);
            command.Parameters.Add("@categoryName", System.Data.SqlDbType.NVarChar).Value = category.categoryName;
            try
            {
                connection.Open();
                check = command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return check;
        }
        public Category GetCategoryById(int id)
        {
            Category category = null;
            String sql = "SELECT categoryName FROM tblCategories WHERE categoryId = @categoryId";
            connection = new SqlConnection(DBInteraction.GetConnectionString());
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@categoryId", id);
            try
            {
                connection.Open();
                dataReader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                if (dataReader.HasRows)
                {
                    if (dataReader.Read())
                    {
                        string categoryName = (string)dataReader["categoryName"];
                        category = new Category(id, categoryName);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return category;
        }
        public Boolean UpdateCategory(Category category)
        {
            Boolean check = false;
            connection = new SqlConnection(DBInteraction.GetConnectionString());
            string sql = "UPDATE tblCategories SET categoryName = @categoryName WHERE categoryId = @categoryId";
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@categoryName", category.categoryName);
            command.Parameters.AddWithValue("@categoryId", category.categoryId);
            try
            {
                connection.Open();
                check = command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return check;
        }
        public Boolean RemoveCategory(Category category)
        {
            Boolean check = false;
            connection = new SqlConnection(DBInteraction.GetConnectionString());
            string sql = "DELETE tblCategories WHERE categoryId = @categoryId";
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@categoryId", category.categoryId);
            try
            {
                connection.Open();
                check = command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return check;
        }
    }

}
