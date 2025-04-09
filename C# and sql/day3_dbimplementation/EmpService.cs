using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace day3_dbimplementation
{
    public class EmpService : EmpRepo
    {
        SqlConnection con;
        public EmpService()
        {
             con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=aniketaprilbatch;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true");
            con.Open();
        }


        public void AddEmp()
        {

            string name, email, dept;
            double salary;

            Console.WriteLine("Enter Name ");
            name= Console.ReadLine();
            
            Console.WriteLine("Enter Email ");
            email= Console.ReadLine();
            
            Console.WriteLine("Enter Department ");
            dept= Console.ReadLine();
            
            Console.WriteLine("Enter Salary ");
            salary= double.Parse(Console.ReadLine());

            try
            {
                string query = $"exec addemployee '{name}','{email}','{salary}','{dept}'";
                SqlCommand cmd = new SqlCommand(query,con);

                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee Entered Succesfully");
                Console.WriteLine();
                Console.WriteLine();



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }



        public void showemplist()
        {
            string query = "exec fetchdata";
            SqlCommand cmd = new SqlCommand(query,con);

            SqlDataReader reader = cmd.ExecuteReader();

            try {

                if (reader.HasRows)
                {


                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id"].ToString());
                        string name = reader["name"].ToString();
                        string email = reader["email"].ToString();
                        string dept = reader["dept"].ToString();
                        double salary = double.Parse(reader["salary"].ToString());
                        double netsal = double.Parse(reader["netsal"].ToString());


                        Console.WriteLine($"Employee ID={id}\n NAME={name}\n EMAIL={email}\n DEPT={dept}\n SALARY={salary}\n NetSalary={netsal}");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("No Employee Data");
                }


            }
            catch (Exception ex) 
            {
               
                Console.WriteLine(ex.Message);
            }

            
        }


        public void updateemp()
        {
            try
            {
                

                Console.WriteLine("Enter The ID For Update");
                int id = int.Parse(Console.ReadLine());

                string name, email, dept;
                double salary;

                Console.WriteLine("Enter Name ");
                name = Console.ReadLine();

                Console.WriteLine("Enter Email ");
                email = Console.ReadLine();

                Console.WriteLine("Enter Department ");
                dept = Console.ReadLine();

                Console.WriteLine("Enter Salary ");
                salary = double.Parse(Console.ReadLine());

                string query = $"exec updateempdata '{name}','{email}','{salary}','{dept}','{id}' ";

                SqlCommand cmd = new SqlCommand(query,con);

                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee Data Update Succesfully");
                Console.WriteLine();
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void deleteemplist()
        {
            

            try
            {
                Console.WriteLine("Enter the Id To Delete The Employee Data");
                int id = int.Parse(Console.ReadLine());
                string query = $"exec deletedata '{id}'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                Console.WriteLine();
                Console.WriteLine("Employee data deleted Succesfully");
                Console.WriteLine();


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }


        public void readdata()
        {
            try
            {
                Console.WriteLine("Enter The Id Of Employee To Fetch Data");
                int id = int.Parse(Console.ReadLine());

                string query = $"exec readperticulardata '{id}'";

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        int idd = int.Parse(rdr["id"].ToString());
                        string name = rdr["name"].ToString();
                        string email = rdr["email"].ToString();
                        string dept = rdr["dept"].ToString();
                        double salary = double.Parse(rdr["salary"].ToString());
                        double netsal = double.Parse(rdr["netsal"].ToString());


                        Console.WriteLine($"Employee ID={idd}\n NAME={name}\n EMAIL={email}\n DEPT={dept}\n SALARY={salary}\n NetSalary={netsal}");
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("No Record Found");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public void searchemp()
            {
            try
            {
                Console.WriteLine("Enter Employee Name Or Depart Name");
                string str = Console.ReadLine();

                string query = $"exec searchemployee '{str}'";

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        int idd = int.Parse(rdr["id"].ToString());
                        string name = rdr["name"].ToString();
                        string email = rdr["email"].ToString();
                        string dept = rdr["dept"].ToString();
                        double salary = double.Parse(rdr["salary"].ToString());
                        double netsal = double.Parse(rdr["netsal"].ToString());


                        Console.WriteLine($"Employee ID={idd}\n NAME={name}\n EMAIL={email}\n DEPT={dept}\n SALARY={salary}\n NetSalary={netsal}");
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("No Record Found");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
