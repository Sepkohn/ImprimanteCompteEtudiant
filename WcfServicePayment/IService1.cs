using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DTO;
    
namespace WcfServicePayment
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here

        [OperationContract]
        User GetUserById(int uid);

        [OperationContract]
        User GetUserByCardId(int cardId);

        [OperationContract]
        User GetUserByUsername(string username);

        [OperationContract]
        decimal AddCredit(User user, decimal credit);

        [OperationContract]
        decimal GetBalance(User user);

        [OperationContract]
        decimal Print(User user, int nbCopies);

        [OperationContract]
        int UpdateCopy(User user, int nbCopies, bool copyToDo);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
