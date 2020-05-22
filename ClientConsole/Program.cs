using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServicePaiement;
using DTO;

namespace ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {


            User student = IPaiementService.GetUserById(3);


        }
    }
}
