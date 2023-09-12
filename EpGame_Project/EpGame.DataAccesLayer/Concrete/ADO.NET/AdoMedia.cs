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
	public class AdoMedia : IMediaDAL
	{
		private string connectionString; // Veritabanı bağlantı dizesi

		public AdoMedia(string connectionString)
		{
			this.connectionString = connectionString;
		}

		public bool Add(Media entity)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					string query = "INSERT INTO Media (MediaURL, MediaTypeID, GameID, AltText) " +
								   "VALUES (@MediaURL, @MediaTypeID, @GameID, @AltText)";

					SqlCommand command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@MediaURL", entity.MediaURL);
					command.Parameters.AddWithValue("@MediaTypeID", entity.MediaTypeID);
					command.Parameters.AddWithValue("@GameID", entity.GameID);
					command.Parameters.AddWithValue("@AltText", entity.AltText);

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

		public bool Delete(Media entity)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					string query = "DELETE FROM Media WHERE ID = @ID";

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

		public Media Get(int id)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "SELECT * FROM Media WHERE ID = @ID";

				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@ID", id);

				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					Media media = new Media
					{
						ID = (int)reader["ID"],
						MediaURL = (string)reader["MediaURL"],
						MediaTypeID = (int)reader["MediaTypeID"],
						GameID = (int)reader["GameID"],
						AltText = (string)reader["AltText"]
					};
					return media;
				}
				return null;
			}
		}

		public List<Media> GetAll()
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "SELECT * FROM Media";

				SqlCommand command = new SqlCommand(query, connection);

				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				List<Media> mediaList = new List<Media>();

				while (reader.Read())
				{
					Media media = new Media
					{
						ID = (int)reader["ID"],
						MediaURL = (string)reader["MediaURL"],
						MediaTypeID = (int)reader["MediaTypeID"],
						GameID = (int)reader["GameID"],
						AltText = (string)reader["AltText"]
					};
					mediaList.Add(media);
				}
				return mediaList;
			}
		}

		public bool Update(Media entity)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					string query = "UPDATE Media SET MediaURL = @MediaURL, MediaTypeID = @MediaTypeID, GameID = @GameID, AltText = @AltText " +
								   "WHERE ID = @ID";

					SqlCommand command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@ID", entity.ID);
					command.Parameters.AddWithValue("@MediaURL", entity.MediaURL);
					command.Parameters.AddWithValue("@MediaTypeID", entity.MediaTypeID);
					command.Parameters.AddWithValue("@GameID", entity.GameID);
					command.Parameters.AddWithValue("@AltText", entity.AltText);

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
