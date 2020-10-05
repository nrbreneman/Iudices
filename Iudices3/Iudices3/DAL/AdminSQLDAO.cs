using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Iudices3.Models;

namespace Iudices3.DAL
{
    public class AdminSQLDAO : IAdminDAL
    {

        private readonly string connectionString;
        private readonly string CreateAdminSQL = "INSERT INTO Users(username, password, salt, role) VALUES (@username, @password, @salt, Admin); ";
        private readonly string CreateUserSQL = "INSERT INTO Users(username, password, salt, role) VALUES (@username, @password, @salt, User); ";
        private readonly string DeleteUserSQL = "DELETE FROM Users WHERE id = @id; ";
        private readonly string CreateJurorSQL = "INSERT INTO Roster(firstName, lastName, streetAddress, city, stateABV, zipcode) VALUES (@firstName, @lastName , @streetAddress, @city, @stateABV, @zipcode);";
        private readonly string DeleteJurorSQL = "Delete from roster where rosterID = @id";
        private readonly string UpdateJurorSQL = "Update roster set firstName = @FirstName, lastName = @LastName, streetAddress = streetAddress, city = @city, stateABV = @stateABV, zipcode = @zipcode where rosterID = @ID";


        public AdminSQLDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void CreateAdmin(User user)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(CreateAdminSQL, conn);
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

        public void CreateJuror(Juror juror)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(CreateJurorSQL, conn);
                    cmd.Parameters.AddWithValue("@firstName", juror.firstName);
                    cmd.Parameters.AddWithValue("@lastName", juror.lastName);
                    cmd.Parameters.AddWithValue("@streetAddress", juror.streetAddress);
                    cmd.Parameters.AddWithValue("@city", juror.city);
                    cmd.Parameters.AddWithValue("@stateABV", juror.state);
                    cmd.Parameters.AddWithValue("@zipcode", juror.zipcode);

                    cmd.ExecuteNonQuery();

                    return;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void DeleteJuror(Juror juror)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(DeleteJurorSQL, conn);
                    cmd.Parameters.AddWithValue("@id", juror.ID);

                    cmd.ExecuteNonQuery();

                    return;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }

        public void UpdateJuror(Juror juror)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(UpdateJurorSQL, conn);
                    cmd.Parameters.AddWithValue("@firstName", juror.firstName);
                    cmd.Parameters.AddWithValue("@lastName", juror.lastName);
                    cmd.Parameters.AddWithValue("@streetAddress", juror.streetAddress);
                    cmd.Parameters.AddWithValue("@city", juror.city);
                    cmd.Parameters.AddWithValue("@stateABV", juror.state);
                    cmd.Parameters.AddWithValue("@zipcode", juror.zipcode);

                    cmd.ExecuteNonQuery();

                    return;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
