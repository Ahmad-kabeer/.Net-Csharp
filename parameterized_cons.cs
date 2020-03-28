using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Parameterized_cons
    {
        int x;                                                /// initialize variable x
        public Parameterized_cons(int i)                      /// defining constructor
        {
            x = i;                                            ///passing value
            Console.WriteLine("this constructor is called with parameter that is i values=" + i);
        }
        public void display()                                 /// define method to display the value of x
        {
            Console.WriteLine("value of x is" + x);
        }
        static void Main(string[] arg)
        {
            Parameterized_cons obj1 = new Parameterized_cons(10);                       ///calling constructor
            Parameterized_cons obj2 = new Parameterized_cons(20);
            obj1.display();                                                            ///calling display method                            
            obj2.display();
            Console.ReadLine();
        }
    }
}
