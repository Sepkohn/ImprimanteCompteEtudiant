using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserManager : IUserManager
    {
        private IUserDB UserDb { get; }

        public UserManager(IUserDB userDb)
        {
            UserDb = userDb;
        }

        public User GetUserById(int id)
        {
            return UserDb.GetUserById(id);
        }

        public User GetUserByCardId(int id)
        {
            return UserDb.GetUserByCardId(id);
        }

        public User GetUserByUsername(string username)
        {
            return UserDb.GetUserByUsername(username);
        }

        public int UpdateBalance(User user)
        {
            return UserDb.UpdateBalance(user);
        }

        public String GetBalance(User user)
        {
            return $"Vous avez un solde de CHF {user.Balance}, soit {(int)(user.Balance / 0.08)} photocopies";
        }
    }
}
