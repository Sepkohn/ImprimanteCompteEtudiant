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

        public UserManager()
        {
            UserDb = new UserDB();
        }

        public User GetUserById(int uid)
        {
            return UserDb.GetUserById(uid);
        }

        public User GetUserByCardId(int cardId)
        {
            return UserDb.GetUserByCardId(cardId);
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
            return $"Vous avez un solde de CHF {user.Balance}, soit {(int)(user.Balance / (decimal)0.08)} photocopies";
        }

    }
}
