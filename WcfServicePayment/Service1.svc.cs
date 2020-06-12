using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DTO;
using BLL;
using System.ServiceModel.PeerResolvers;

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

  //          UpdateCopy(user, 0, false);

            return user.Balance;
        }

        public decimal Print(User user, int nbCopies)
        {
            double cost = PRICE * nbCopies;

            user.Balance -= (decimal)cost;

            UserManager.UpdateBalance(user);

            return user.Balance;
        }

        public int UpdateCopy(User user, int nbCopies, bool copyToDo)
        {            
            int copyAvailable = (int)((double)user.Balance / PRICE);
            
            if (copyToDo)
            {
                double cost = PRICE * nbCopies;
                var BalanceInit = user.Balance;
                var balanceTemp = user.Balance;
                bool validBalance;

                balanceTemp -= (decimal)cost;

                if(!positive(balanceTemp))
                {
                    validBalance = positive(balanceTemp);

                    while (!validBalance)
                    {
                        balanceTemp = BalanceInit;
                        nbCopies -= 1;
                        cost = PRICE * nbCopies;

                        balanceTemp -= (decimal)cost;
                        validBalance = positive(balanceTemp);
                    }

                }

                user.Balance = balanceTemp;

                copyAvailable -= nbCopies;

                UserManager.UpdateBalance(user);

            }

            return copyAvailable;
        }

     public bool positive(Decimal balance)
        { 
            if(balance < 0) { return false; }
            return true;
        }
        
       public string GetBalance(User user)
        {
            return UserManager.GetBalance(user);
        }
    }
}
