
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
            connectionString = ConfigurationManager.ConnectionStrings["PaymentDataBase"].ConnectionString;
        }

        public User GetUserById(int uid)
        {
            User user = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM [dbo].[User] WHERE Uid = @uid";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@uid", uid);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            user = new User
                            {
                                Uid = (int)dr["Uid"],

                                CardId = (int)dr["CardId"],

                                Username = (string)dr["Username"],

                                Balance = (decimal)dr["Balance"]
                            };

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

            connectionString = ConfigurationManager.ConnectionStrings["PaymentDataBase"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM [dbo].[User] where CardId = @cardId";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@cardId", cardId);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            user = new User();

                            user.Uid = (int)dr["Uid"];

                            user.CardId = (int)dr["CardId"];

                            user.Username = (string)dr["Username"];

                            user.Balance = (decimal)dr["Balance"];

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
                    string query = "SELECT * FROM [dbo].[User] where Username = @username";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            user = new User();

                            user.Uid = (int)dr["Uid"];

                            user.CardId = (int)dr["CardId"];

                            user.Username = (string)dr["Username"];

                            user.Balance = (decimal)dr["Balance"];

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
                    string query = "UPDATE [dbo].[User] SET Balance=@balance WHERE Uid=@uid";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@balance", user.Balance);
                    cmd.Parameters.AddWithValue("@uid", user.Uid);

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

