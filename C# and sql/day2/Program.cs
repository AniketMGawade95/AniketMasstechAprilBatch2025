using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{

     class dog
    {
        public void voice()
        {
            Console.WriteLine("Bark");
        }
    }

    public class a
    {

        private int x;

        public int xx {
            get { return x; }
            set { x = value; }
        }

        public void dis1()
        {
            Console.WriteLine("dish 1");
        }
        public void dis3()
        {
            Console.WriteLine("dish 3");
        }
    }

    public class b : a
    {
        public void dis2()
        {
            base.dis1();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {


            dog dd = new dog();
            dd.voice();

            a aaa= new a();
            aaa.xx = 9;
            Console.WriteLine(aaa.xx);
            Console.WriteLine(); 

            b bbb= new b();
            bbb.dis2();


            Console.WriteLine();

            emp.intro();

            emp nn=new emp();

            new emp().add(3,3);
            nn.add(5, 5);

            double Mul=nn.mul(5, 5);
            Console.WriteLine($"Multipication={Mul}");

            string Name = nn.name("Aniket");
            Console.WriteLine(Name);

            Console.WriteLine();

            int id;
            string name;
            double salary, pf, netsal;

            Console.WriteLine("Enter ID");
            id = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter Name");
            name = Console.ReadLine();


            Console.WriteLine("Enter Salary");
            salary = int.Parse(Console.ReadLine());

            pf = 0.1 * salary;

            netsal = salary - pf;


            Console.WriteLine($" ID = {id}, Name= {name} , Salary= {salary}, Pf={pf}, Net Salary={netsal}");

            Console.ReadKey();
        }
    }
}
