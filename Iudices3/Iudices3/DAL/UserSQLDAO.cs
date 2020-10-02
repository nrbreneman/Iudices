using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Iudices3.Models;

namespace Iudices3.DAL
{
    public class UserSQLDAO : IUserDAL
    {
        private readonly string connectionString;

        private readonly string CreateUserSQL = "INSERT INTO Users(username, password, salt, role) VALUES (@username, @password, @salt, @role); ";
        private readonly string DeleteUserSQL = "DELETE FROM Users WHERE id = @id; ";
        private readonly string GetUserSQL = "SELECT * FROM Users WHERE username = @username; ";
        private readonly string UpdateUserSQL = "UPDATE Users SET password = @password, salt = @salt, role = @role WHERE id = @id; ";

        public UserSQLDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void CreateUser(User user)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(CreateUserSQL, conn);
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@password", user.Password);
                    cmd.Parameters.AddWithValue("@salt", user.Salt);
                    cmd.Parameters.AddWithValue("@role", user.Role);

                    cmd.ExecuteNonQuery();

                    return;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void DeleteUser(User user)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(DeleteUserSQL, conn);
                    cmd.Parameters.AddWithValue("@id", user.Id);

                    cmd.ExecuteNonQuery();

                    return;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public User GetUser(string username)
        {
            User user = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(GetUserSQL, conn);
                    cmd.Parameters.AddWithValue("@username", username);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        user = MapRowToUser(reader);
                    }
                }

                return user;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(UpdateUserSQL, conn);
                    cmd.Parameters.AddWithValue("@password", user.Password);
                    cmd.Parameters.AddWithValue("@salt", user.Salt);
                    cmd.Parameters.AddWithValue("@role", user.Role);
                    cmd.Parameters.AddWithValue("@id", user.Id);

                    cmd.ExecuteNonQuery();

                    return;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private User MapRowToUser(SqlDataReader reader)
        {
            User user = new User();
            user.Id = Convert.ToInt32(reader["id"]);
            user.Username = Convert.ToString(reader["username"]);
            user.Password = Convert.ToString(reader["password"]);
            user.Salt = Convert.ToString(reader["salt"]);
            user.Role = Convert.ToString(reader["role"]);
            return user;
        }
    }
}
