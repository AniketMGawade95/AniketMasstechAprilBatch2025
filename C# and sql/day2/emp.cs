using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{

  
     class emp
    {

        public static void intro()
        {
            Console.WriteLine("Its intro method");
        }
        public void add(int a,int b)
        {

            int c = a + b;
            Console.WriteLine($"Addition={c}");
        }

        public string name(string nam)
        {
            return nam;
        }

        public double mul(int x,int y)
        {
            double z = x * y;
            return z;
        }
        
    }
}
