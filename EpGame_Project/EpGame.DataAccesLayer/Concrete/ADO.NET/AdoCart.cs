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
	public class AdoCart : ICartDAL
	{
		private string connectionString; // Veritabanı bağlantı dizesi

		public AdoCart(string connectionString)
		{
			this.connectionString = connectionString;
		}

		public bool Add(Cart entity)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "INSERT INTO Cart (GameID, AppUserID, TotalPrice) " +
							   "VALUES (@GameID, @AppUserID, @TotalPrice)";

				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@GameID", entity.GameID);
				command.Parameters.AddWithValue("@AppUserID", entity.AppUserID);
				command.Parameters.AddWithValue("@TotalPrice", entity.TotalPrice);

				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();
				return rowsAffected > 0;
			}
		}

		public bool Delete(Cart entity)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "DELETE FROM Cart WHERE ID = @ID";

				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@ID", entity.ID);

				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();
				return rowsAffected > 0;
			}
		}

		public Cart Get(int id)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "SELECT * FROM Cart WHERE ID = @ID";

				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@ID", id);

				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					Cart cart = new Cart
					{
						ID = (int)reader["ID"],
						GameID = (int)reader["GameID"],
						AppUserID = (int)reader["AppUserID"],
						TotalPrice = (double)reader["TotalPrice"]
					};
					return cart;
				}
				return null;
			}
		}

		public List<Cart> GetAll()
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "SELECT * FROM Cart";

				SqlCommand command = new SqlCommand(query, connection);

				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				List<Cart> carts = new List<Cart>();

				while (reader.Read())
				{
					Cart cart = new Cart
					{
						ID = (int)reader["ID"],
						GameID = (int)reader["GameID"],
						AppUserID = (int)reader["AppUserID"],
						TotalPrice = (double)reader["TotalPrice"]
					};
					carts.Add(cart);
				}
				return carts;
			}
		}

		public bool Update(Cart entity)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "UPDATE Cart SET GameID = @GameID, AppUserID = @AppUserID, TotalPrice = @TotalPrice " +
							   "WHERE ID = @ID";

				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@ID", entity.ID);
				command.Parameters.AddWithValue("@GameID", entity.GameID);
				command.Parameters.AddWithValue("@AppUserID", entity.AppUserID);
				command.Parameters.AddWithValue("@TotalPrice", entity.TotalPrice);

				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();
				return rowsAffected > 0;
			}
		}
	}
}
