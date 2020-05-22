
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
            connectionString = ConfigurationManager.ConnectionStrings["PaiementDataBase"].ConnectionString;
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
                            user.LastName = (string)dr["Lastname"];

                            if (dr["Username"] != null)
                                user.UserName = (string)dr["Username"];

                            if (dr["CardId"] != null)
                                user.CardId = (int)dr["CardId"];

                            user.Balance = (double)dr["Balance"];

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

        public User GetUserByCardId(int cardId)
        {
            User user = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM User where CardId = @cardId";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@cardId", cardId);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            user = new User();

                            user.Id = (int)dr["Id"];
                            user.FirstName = (string)dr["FirstName"];
                            user.LastName = (string)dr["Lastname"];

                            if (dr["Username"] != null)
                                user.UserName = (string)dr["Username"];

                            if (dr["CardId"] != null)
                                user.CardId = (int)dr["CardId"];

                            user.Balance = (double)dr["Balance"];

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

        public User GetUserByUsername(string username)
        {
            User user = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM User where Username = @username";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            user = new User();

                            user.Id = (int)dr["Id"];
                            user.FirstName = (string)dr["FirstName"];
                            user.LastName = (string)dr["Lastname"];

                            if (dr["Username"] != null)
                                user.UserName = (string)dr["Username"];

                            if (dr["CardId"] != null)
                                user.CardId = (int)dr["CardId"];

                            user.Balance = (double)dr["Balance"];

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

        public int UpdateBalance(User user)
        {
            int result = 0;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE User SET Balance=@balance";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@balance", user.Balance);

                    cn.Open();

                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }
    }
}

