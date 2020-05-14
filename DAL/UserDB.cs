
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class UserDB : IUserDB
    {
        private string connectionString = null;
        public UserDB()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DemoDB"].ConnectionString;
        }

        public User GetUserById(int id)
        {
            User user = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM User where Id = @id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            user = new User();

                            user.Id = (int)dr["Id"];
                            user.FirstName = (string)dr["FirstName"];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return user;
        }
    }
}

