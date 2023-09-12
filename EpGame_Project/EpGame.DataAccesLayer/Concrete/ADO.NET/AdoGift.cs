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
	public class AdoGiftRepository : IGiftDAL
	{
		private string connectionString; // Veritabanı bağlantı dizesi

		public AdoGiftRepository(string connectionString)
		{
			this.connectionString = connectionString;
		}

		public bool Add(Gift entity)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					string query = "INSERT INTO Gift (GameID, SendUserID, ReceiverUserID) " +
								   "VALUES (@GameID, @SendUserID, @ReceiverUserID)";

					SqlCommand command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@GameID", entity.GameID);
					command.Parameters.AddWithValue("@SendUserID", entity.SendUserID);
					command.Parameters.AddWithValue("@ReceiverUserID", entity.ReceiverUserID);

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

		public bool Delete(Gift entity)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					string query = "DELETE FROM Gift WHERE ID = @ID";

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

		public Gift Get(int id)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "SELECT * FROM Gift WHERE ID = @ID";

				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@ID", id);

				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					Gift gift = new Gift
					{
						ID = (int)reader["ID"],
						GameID = (int)reader["GameID"],
						SendUserID = (int)reader["SendUserID"],
						ReceiverUserID = (int)reader["ReceiverUserID"]
					};
					return gift;
				}
				return null;
			}
		}

		public List<Gift> GetAll()
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "SELECT * FROM Gift";

				SqlCommand command = new SqlCommand(query, connection);

				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				List<Gift> gifts = new List<Gift>();

				while (reader.Read())
				{
					Gift gift = new Gift
					{
						ID = (int)reader["ID"],
						GameID = (int)reader["GameID"],
						SendUserID = (int)reader["SendUserID"],
						ReceiverUserID = (int)reader["ReceiverUserID"]
					};
					gifts.Add(gift);
				}
				return gifts;
			}
		}

		public bool Update(Gift entity)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					string query = "UPDATE Gift SET GameID = @GameID, SendUserID = @SendUserID, ReceiverUserID = @ReceiverUserID " +
								   "WHERE ID = @ID";

					SqlCommand command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@ID", entity.ID);
					command.Parameters.AddWithValue("@GameID", entity.GameID);
					command.Parameters.AddWithValue("@SendUserID", entity.SendUserID);
					command.Parameters.AddWithValue("@ReceiverUserID", entity.ReceiverUserID);

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

