using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServicePayment;
using DTO;

namespace ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (PaymentService.Service1Client myService = new PaymentService.Service1Client())
            {
                Console.WriteLine("Starting the programm");

                User student = myService.GetUserByCardId(256);

                Console.WriteLine($"Here is Student  : {student}");

                myService.AddCredit(student, 20);

                myService.GetBalance(student);
            }

            Console.Read();
        }
    }
}
