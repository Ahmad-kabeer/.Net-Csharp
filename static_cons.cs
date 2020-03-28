using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Static_cons
    {
        static Static_cons()
        {
            Console.WriteLine("static constructor executed");
        }
        static void Main()
        {
            /// no need to create object for static constructor
            Console.WriteLine("main method is executed");
            Console.ReadLine();
        }
    }
}

/// point to remember
/// 1. if a class contain any static variable then only implicit static constructor will be present otherwise we need to define them explicity whereas non-static constructor will be implicitly defined in every class (except static class)
/// 2. static constructor are responsible in initializing static varieble and these constructor are  called only implicitly no need to create object and the static constructor execute first by implicitly.
