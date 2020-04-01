using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace porject1
{
    class class1
    {
        public class1()
        {
            Console.WriteLine("constructor of class1 is execute");
        }
        public void test1()
        {
            Console.WriteLine("test1 of class1 is executed");
        }
        public void test2()
        {
            Console.WriteLine("test2 of class1 is executed");
        }
        static void Main()
        {
            //class1 c1 = new class1();
            //c1.test1();
            //c1.test2();
            //Console.ReadLine();
        }
    }
    class class2 : class1   //inherit  class1 means consuming the member of class1 in class2
    {
        public class2()
        {
            Console.WriteLine("constructor of class2 is execute");
        }
        public void test3()
        {
            Console.WriteLine("test3 of class2 is executed");
        }
        static void Main()
        {
            class1 c1;      //variable of class1
            class2 c2 = new class2();
            c1 = c2;    //refernce (variable of class1 is initialized by instance of class2)
            //c1.test1();     with the instance of parents class,user can access to parents classs member not child class member.
            //c1.test2();
            c2.test1();
            c2.test2();
            c2.test3();
            Console.ReadLine();
        }
    }
}
