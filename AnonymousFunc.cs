using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public delegate string welcome(string b);                 //In MultiCastDelegate, parameter and return type should be same.
    class AnonymousFunc
    {
        static void Main()
        {
            //welcome wl = delegate (string name)
            //{
            //   return "hello " + name + " is a good a person.";
            //};
            //string a = wl.Invoke("xyz");
            //Console.WriteLine(a);
            //Console.ReadLine();

            welcome wl = delegate(string name)
            {
                return "hello " + name + " is a good a person.";
            };
            var a = wl.Invoke("XYZ");
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
