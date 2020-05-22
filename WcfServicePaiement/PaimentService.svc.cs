using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BLL;
using DTO;

namespace WcfServicePaiement
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class PaimentService : IPaiementService
    {

        public IUserManager manager { get ; set ; }

       /* public string GetData(int value)
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
        }*/

        public User GetUserById(int id) 
        {
            User student = manager.GetUserById(id);

            return student;
        }

        public User GetUserByCardId(int cardId)
        {
            User student = manager.GetUserByCardId(cardId);

            return student;
        }

        public User GetUserByUsername(string username)
        {
            User student = manager.GetUserByUsername(username);

            return student;
        }

        public double AddCredit(User user, double credit) 
        {
            user.Balance += credit;

            manager.UpdateBalance(user);

            Console.WriteLine(manager.GetBalance(user));

            return user.Balance;
        }

    }
}
