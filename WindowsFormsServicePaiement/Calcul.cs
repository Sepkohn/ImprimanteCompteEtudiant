using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WindowsFormsServicePaiement
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calcul" in both code and config file together.
    public class Calcul : ICalcul
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Div(double a, double b)
        {
            return a / b;
        }

        public double Mult(double a, double b)
        {
            return a * b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }

    }
}
