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
                Console.WriteLine("lancement du programme");

                 User student = myService.GetUserByCardId(256);

                if (student != null)
                {

                    Console.WriteLine($"Voici mon client : {student}");

                    student.Balance = myService.AddCredit(student, 20);

                    Console.WriteLine($"Il vous reste un solde de {myService.GetBalance(student)} CHF");

                    student.Balance = myService.Print(student, 20);

                    Console.WriteLine($"Il vous reste un solde de {myService.GetBalance(student)} CHF");
                }

                else {
                    Console.WriteLine("Aucun client n'a été trouvé... Veuillez recommencer");                
                }

            }

            Console.Read();

        }
    }
}
