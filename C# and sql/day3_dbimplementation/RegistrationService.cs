using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_dbimplementation
{
    internal class RegistrationService : RegistrationRepo

    {
        SqlConnection con;

        public RegistrationService()
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=aniketaprilbatch;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true");
            con.Open();
        }


        public void Registration()
        {
            try
            {
                Console.WriteLine("\t\tRegistration");
                Console.WriteLine("Enter UserID");
                string userid = Console.ReadLine();

                Console.WriteLine("Enter EmailID");
                string email = Console.ReadLine();

                Console.WriteLine("Enter Password");
                string pass = Console.ReadLine();

                    string query = $"exec addlogin '{userid}','{email}','{pass}'";

                SqlCommand cmd = new SqlCommand(query,con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Registration complete");

            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }         




        }


        public void signinn()
        {
            try
            {
                Console.WriteLine("Enter UserID");
                string userid = Console.ReadLine();

             

                Console.WriteLine("Enter Password");
                string pass = Console.ReadLine();

                string query = $"exec signin '{userid}','{pass}'";

                SqlCommand cmd = new SqlCommand(query,con);

                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    EmpService empService = new EmpService();
                    while (true)
                    {
                        Console.WriteLine("Select Your Choice\n 1.Add Employee\n 2.Update Employee\n 3.Show Employee List\n 4.Delete Employee\n 5.Read Employee Data\n 6.search all employee with same name or dept \n 7.Exit");

                        Console.WriteLine();
                        int choice = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine();

                        if (choice == 1)
                        {
                            empService.AddEmp();
                        }
                        if (choice == 2)
                        {
                            empService.updateemp();
                        }
                        if (choice == 3)
                        {
                            empService.showemplist();
                        }
                        if (choice == 4)
                        {
                            empService.deleteemplist();
                        }
                        if (choice == 5)
                        {
                            empService.readdata();
                        }
                        if (choice == 6)
                        {
                            empService.searchemp();
                        }
                        if (choice == 7)
                        {
                            break;
                        }


                    }
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}
