using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DTO;
using BLL;

namespace WcfServicePayment
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public const double PRICE = 0.08;
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        private IUserManager UserManager { get; }

        public Service1()
        {
            UserManager = new UserManager();
        }


        public User GetUserById(int uid)
        {
            User student = UserManager.GetUserById(uid);

            return student;
        }

        public User GetUserByCardId(int cardId)
        {
            User student = UserManager.GetUserByCardId(cardId);

            return student;
        }

        public User GetUserByUsername(string username)
        {
            User student = UserManager.GetUserByUsername(username);

            return student;
        }

        public decimal AddCredit(User user, decimal credit)
        {
            user.Balance += credit;

            UserManager.UpdateBalance(user);

            return user.Balance;
        }

        public decimal Print(User user, int nbCopies)
        {
            double cost = PRICE * nbCopies;
            user.Balance -= (decimal)cost;
            UserManager.UpdateBalance(user);

            return user.Balance;
        }

        public void GetBalance(User user)
        {
            string message = UserManager.GetBalance(user);
            Console.WriteLine(message);

        }
    }
}
