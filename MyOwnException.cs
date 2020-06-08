using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MyOwnException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "attempted to divide by odd number";
            }
        }
    }
    public class demo
    {
        static void Main()
        {
            Console.WriteLine("enter 1st number");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            int b = Int32.Parse(Console.ReadLine());
            if (b % 2 > 0)
            {
                throw new MyOwnException();
                //          OR
                //MyOwnException ex1 = new MyOwnException();
                //throw ex1;
            }
            int c = a / b;
            Console.WriteLine("result is = " + c);
            Console.ReadLine();
        }
    }
}

