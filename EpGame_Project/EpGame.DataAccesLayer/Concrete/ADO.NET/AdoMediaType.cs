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
	public class AdoMediaType : IMediaTypeDAL
	{
		private string connectionString; // Veritabanı bağlantı dizesi

		public AdoMediaType(string connectionString)
		{
			this.connectionString = connectionString;
		}

		public bool Add(MediaType entity)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					string query = "INSERT INTO MediaType (MediaTypeName, MediaSize) " +
								   "VALUES (@MediaTypeName, @MediaSize)";

					SqlCommand command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@MediaTypeName", entity.MediaTypeName);
					command.Parameters.AddWithValue("@MediaSize", entity.MediaSize);

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

		public bool Delete(MediaType entity)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					string query = "DELETE FROM MediaType WHERE ID = @ID";

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

		public MediaType Get(int id)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "SELECT * FROM MediaType WHERE ID = @ID";

				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@ID", id);

				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					MediaType mediaType = new MediaType
					{
						ID = (int)reader["ID"],
						MediaTypeName = (string)reader["MediaTypeName"],
						MediaSize = (double)reader["MediaSize"]
					};
					return mediaType;
				}
				return null;
			}
		}

		public List<MediaType> GetAll()
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "SELECT * FROM MediaType";

				SqlCommand command = new SqlCommand(query, connection);

				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				List<MediaType> mediaTypes = new List<MediaType>();

				while (reader.Read())
				{
					MediaType mediaType = new MediaType
					{
						ID = (int)reader["ID"],
						MediaTypeName = (string)reader["MediaTypeName"],
						MediaSize = (double)reader["MediaSize"]
					};
					mediaTypes.Add(mediaType);
				}
				return mediaTypes;
			}
		}

		public bool Update(MediaType entity)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					string query = "UPDATE MediaType SET MediaTypeName = @MediaTypeName, MediaSize = @MediaSize " +
								   "WHERE ID = @ID";

					SqlCommand command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@ID", entity.ID);
					command.Parameters.AddWithValue("@MediaTypeName", entity.MediaTypeName);
					command.Parameters.AddWithValue("@MediaSize", entity.MediaSize);

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
