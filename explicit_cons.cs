using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class explicit_cons
    {
        public explicit_cons()      ///defining constructor
        {
            Console.WriteLine("this explicit constructor is called");
        }
        static void Main(string[] arg)
        {
            explicit_cons obj1 = new explicit_cons();    ///number of object is equal to no. of calling.
            explicit_cons obj2 = new explicit_cons();
            Console.ReadLine();
        }
    }
}
