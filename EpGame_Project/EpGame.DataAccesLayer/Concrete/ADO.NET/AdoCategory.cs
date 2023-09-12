using EpGame.DataAccesLayer.Abstract;
using EpGame.EntityLayer.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpGame.DataAccesLayer.Concrete.ADO.NET
{
	public class AdoCategory : ICategoryDAL
	{
		private string connectionString; // Veritabanı bağlantı dizesi

		public AdoCategory(string connectionString)
		{
			this.connectionString = connectionString;
		}

		public bool Add(Category entity)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "INSERT INTO Category (CategoryName) " +
							   "VALUES (@CategoryName)";

				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@CategoryName", entity.CategoryName);

				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();
				return rowsAffected > 0;
			}
		}

		public bool Delete(Category entity)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "DELETE FROM Category WHERE ID = @ID";

				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@ID", entity.ID);

				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();
				return rowsAffected > 0;
			}
		}

		public Category Get(int id)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "SELECT * FROM Category WHERE ID = @ID";

				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@ID", id);

				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					Category category = new Category
					{
						ID = (int)reader["ID"],
						CategoryName = (string)reader["CategoryName"]
					};
					return category;
				}
				return null;
			}
		}

		public List<Category> GetAll()
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "SELECT * FROM Category";

				SqlCommand command = new SqlCommand(query, connection);

				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				List<Category> categories = new List<Category>();

				while (reader.Read())
				{
					Category category = new Category
					{
						ID = (int)reader["ID"],
						CategoryName = (string)reader["CategoryName"]
					};
					categories.Add(category);
				}
				return categories;
			}
		}

		public bool Update(Category entity)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "UPDATE Category SET CategoryName = @CategoryName " +
							   "WHERE ID = @ID";

				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@ID", entity.ID);
				command.Parameters.AddWithValue("@CategoryName", entity.CategoryName);

				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();
				return rowsAffected > 0;
			}
		}
	}
}
