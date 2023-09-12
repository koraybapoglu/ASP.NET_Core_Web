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
	public class AdoGameCategory : IGameCategoryDAL
	{
		private string connectionString; // Veritabanı bağlantı dizesi

		public AdoGameCategory(string connectionString)
		{
			this.connectionString = connectionString;
		}

		public bool Add(GameCategory entity)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					string query = "INSERT INTO GameCategory (GameID, CategoryID) " +
								   "VALUES (@GameID, @CategoryID)";

					SqlCommand command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@GameID", entity.GameID);
					command.Parameters.AddWithValue("@CategoryID", entity.CategoryID);

					connection.Open();
					int rowsAffected = command.ExecuteNonQuery();
					return rowsAffected > 0;
				}
			}
			catch
			{
				return false;
			}
		}

		public bool Delete(GameCategory entity)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					string query = "DELETE FROM GameCategory WHERE ID = @ID";

					SqlCommand command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@ID", entity.ID);

					connection.Open();
					int rowsAffected = command.ExecuteNonQuery();
					return rowsAffected > 0;
				}
			}
			catch
			{
				return false;
			}
		}

		public GameCategory Get(int id)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "SELECT * FROM GameCategory WHERE ID = @ID";

				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@ID", id);

				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					GameCategory gameCategory = new GameCategory
					{
						ID = (int)reader["ID"],
						GameID = (int)reader["GameID"],
						CategoryID = (int)reader["CategoryID"]
					};
					return gameCategory;
				}
				return null;
			}
		}

		public List<GameCategory> GetAll()
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "SELECT * FROM GameCategory";

				SqlCommand command = new SqlCommand(query, connection);

				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				List<GameCategory> gameCategories = new List<GameCategory>();

				while (reader.Read())
				{
					GameCategory gameCategory = new GameCategory
					{
						ID = (int)reader["ID"],
						GameID = (int)reader["GameID"],
						CategoryID = (int)reader["CategoryID"]
					};
					gameCategories.Add(gameCategory);
				}
				return gameCategories;
			}
		}

		public bool Update(GameCategory entity)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					string query = "UPDATE GameCategory SET GameID = @GameID, CategoryID = @CategoryID " +
								   "WHERE ID = @ID";

					SqlCommand command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@ID", entity.ID);
					command.Parameters.AddWithValue("@GameID", entity.GameID);
					command.Parameters.AddWithValue("@CategoryID", entity.CategoryID);

					connection.Open();
					int rowsAffected = command.ExecuteNonQuery();
					return rowsAffected > 0;
				}
			}
			catch
			{
				return false;
			}
		}
	}
}
