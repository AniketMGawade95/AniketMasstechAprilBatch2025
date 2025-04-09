using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_dbimplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpService empService = new EmpService();
            RegistrationService regiService = new RegistrationService();

            while (true) 
            {
                Console.WriteLine("Select Your Choice\n 1.Registration\n 2.Login\n 3.Exit");
                Console.WriteLine();
                int choicee = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();

                if (choicee == 1)
                {
                    regiService.Registration();
                }
                if (choicee == 2)
                {
                    regiService.signinn();
                }                
                if (choicee == 3)
                {
                    break;
                }
            }

            
            
        }
    }
}
