using Iudices3.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Iudices3.DAL
{
    public class JurySQLDAO
    {
        private readonly string connectionString = (@"Server=.\SQLEXPRESS;Database=Jury;Trusted_Connection=True;");

        private readonly string GetJurorSQL = "SELECT * FROM Roster where rosterID = @ID;";
        private readonly string GetRowsSQL = "Select COUNT(rosterID) FROM roster";

        public JurySQLDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public JurySQLDAO()
        {
        }

        public int GetRows()
        {
            int rowCount = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(GetRowsSQL, conn);
                    rowCount = Convert.ToInt32(cmd.ExecuteScalar());

                    return rowCount;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


        public Juror GetJuror(int ID)
        {
            Juror juror = new Juror();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(GetJurorSQL, conn);
                    cmd.Parameters.AddWithValue("@ID", ID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        juror.ID = Convert.ToInt32(reader["rosterID"]);
                        juror.firstName = Convert.ToString(reader["firstName"]);
                        juror.lastName = Convert.ToString(reader["lastName"]);
                        juror.streetAddress = Convert.ToString(reader["streetAddress"]);
                        juror.city = Convert.ToString(reader["city"]);
                        juror.state = Convert.ToString(reader["stateABV"]);
                        juror.zipcode = Convert.ToInt32(reader["zipcode"]);

                    }
                }

                return juror;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
