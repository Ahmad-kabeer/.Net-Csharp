using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Copy_cons
    {
        int x;
        public Copy_cons(int i)         ///defining constructor
        {
            x = i;
        }
        public Copy_cons(Copy_cons obj)         //////defining copy constructor
        {
            x = obj.x;
        }
        public void display()           ///defining display method
        {
            Console.WriteLine("value of x is " + x);
        }
        static void Main()              ///main method
        {
            Copy_cons cd1 = new Copy_cons(10);
            cd1.display();
            Copy_cons cd2 = new Copy_cons(cd1);
            cd2.display();
            Console.ReadLine();
        }
    }
    
}