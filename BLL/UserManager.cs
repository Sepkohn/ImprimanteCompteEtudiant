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

        public decimal GetBalance(User user)
        {
            user = GetUserById(user.Uid);

            return user.Balance;
        }

    }
}
