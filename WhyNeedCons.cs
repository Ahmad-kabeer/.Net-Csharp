using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class WhyNeedCons
    {
        public int x =100;
    }
    class Middle
    {
        public int y;
        public Middle(int y)
        {
            this.y = y;
        }
    }
    class Second
    {
        static void Main()
        {
            WhyNeedCons w1 = new WhyNeedCons();
            WhyNeedCons w2 = new WhyNeedCons();
            Console.WriteLine("value of x " + w1.x + " "+ w2.x);
            
            Middle obj1 = new Middle(10);
            Middle obj2 = new Middle(20);
            Console.WriteLine("value of y " + obj1.y + " " + obj2.y);
            Console.ReadLine();

        }
        
    }
}
