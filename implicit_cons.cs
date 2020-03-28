using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SecondClass
    {
        /// this program is to learn imlicit constructor which is known as parameterless constructor and it is public constructor.
        int a; 
        bool b;
        double d;
        static void Main(string[] args)
        {
            SecondClass obj = new SecondClass();

            Console.WriteLine("value of b " + obj.a);
            Console.WriteLine("value of b " + obj.b);
            Console.WriteLine("value of d " + obj.d);
            Console.ReadLine();
        }
    }
}
