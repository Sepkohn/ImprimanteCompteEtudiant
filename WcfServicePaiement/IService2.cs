﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServicePaiement
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService2" in both code and config file together.
    [ServiceContract]
    public interface IService2
    {
        [OperationContract]
        double Add(double a, double b);

        [OperationContract]
        double Sub(double a, double b);

        [OperationContract]
        double Mult(double a, double b);

        [OperationContract]
        double Div(double a, double b);

    }
}
