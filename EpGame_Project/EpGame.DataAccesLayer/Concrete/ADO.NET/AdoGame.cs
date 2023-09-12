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
	public class AdoGame : IGameDAL
	{
		private string connectionString; // Veritabanı bağlantı dizesi

		public AdoGame(string connectionString)
		{
			this.connectionString = connectionString;
		}

		public bool Add(Game entity)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "INSERT INTO Game (GameName, Price, PublishDate, Description, Size, Rating, SystemRequirements, DownloadCount) " +
							   "VALUES (@GameName, @Price, @PublishDate, @Description, @Size, @Rating, @SystemRequirements, @DownloadCount)";

				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@GameName", entity.GameName);
				command.Parameters.AddWithValue("@Price", entity.Price);
				command.Parameters.AddWithValue("@PublishDate", entity.PublishDate);
				command.Parameters.AddWithValue("@Description", entity.Description);
				command.Parameters.AddWithValue("@Size", entity.Size);
				command.Parameters.AddWithValue("@Rating", entity.Rating);
				command.Parameters.AddWithValue("@SystemRequirements", entity.SystemRequirements);
				command.Parameters.AddWithValue("@DownloadCount", entity.DownloadCount);

				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();
				return rowsAffected > 0;
			}
		}

		public bool Delete(Game entity)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "DELETE FROM Game WHERE ID = @ID";

				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@ID", entity.ID);

				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();
				return rowsAffected > 0;
			}
		}

		public Game Get(int id)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "SELECT * FROM Game WHERE ID = @ID";

				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@ID", id);

				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					Game game = new Game
					{
						ID = (int)reader["ID"],
						GameName = (string)reader["GameName"],
						Price = (double)reader["Price"],
						PublishDate = (DateTime)reader["PublishDate"],
						Description = (string)reader["Description"],
						Size = (double)reader["Size"],
						Rating = (double)reader["Rating"],
						SystemRequirements = (string)reader["SystemRequirements"],
						DownloadCount = (int)reader["DownloadCount"]
					};
					return game;
				}
				return null;
			}
		}

		public List<Game> GetAll()
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "SELECT * FROM Game";

				SqlCommand command = new SqlCommand(query, connection);

				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				List<Game> games = new List<Game>();

				while (reader.Read())
				{
					Game game = new Game
					{
						ID = (int)reader["ID"],
						GameName = (string)reader["GameName"],
						Price = (double)reader["Price"],
						PublishDate = (DateTime)reader["PublishDate"],
						Description = (string)reader["Description"],
						Size = (double)reader["Size"],
						Rating = (double)reader["Rating"],
						SystemRequirements = (string)reader["SystemRequirements"],
						DownloadCount = (int)reader["DownloadCount"]
					};
					games.Add(game);
				}
				return games;
			}
		}

		public bool Update(Game entity)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "UPDATE Game SET GameName = @GameName, Price = @Price, PublishDate = @PublishDate, " +
							   "Description = @Description, Size = @Size, Rating = @Rating, SystemRequirements = @SystemRequirements, " +
							   "DownloadCount = @DownloadCount WHERE ID = @ID";

				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@ID", entity.ID);
				command.Parameters.AddWithValue("@GameName", entity.GameName);
				command.Parameters.AddWithValue("@Price", entity.Price);
				command.Parameters.AddWithValue("@PublishDate", entity.PublishDate);
				command.Parameters.AddWithValue("@Description", entity.Description);
				command.Parameters.AddWithValue("@Size", entity.Size);
				command.Parameters.AddWithValue("@Rating", entity.Rating);
				command.Parameters.AddWithValue("@SystemRequirements", entity.SystemRequirements);
				command.Parameters.AddWithValue("@DownloadCount", entity.DownloadCount);

				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();
				return rowsAffected > 0;
			}
		}
	}
}
