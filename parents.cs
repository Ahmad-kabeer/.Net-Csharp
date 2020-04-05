using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class parents
    {
        public virtual void test1()                       //permission to child class to overriding thid method.
        {
            Console.WriteLine("parents test1 is called.");
        }
        public void test2()
        {
            Console.WriteLine("parents test2 is called.");
        }
        public void test3()
        {
            Console.WriteLine("parents test3 is called.");
        }
        public void test4()
        {
            Console.WriteLine("parents test4 is called.");
        }
    }
    class childs : parents
    {
        public void ak()                                  //if it's need to use parents method even after override ,then use  "base","this" keyword.
        {
            base.test1();
        }
        public void hs()                                  //if it's need to use parents method even after method hiding ,then use  "base","this" keyword.
        {
            base.test2();
        }
        public override void test1()                     //after permission from parent ,overriding by using "override" keyword.(re-implement code by overriding)
        {
            Console.WriteLine("child test1 is called.");
        }
        public new void test2()                         //re-implement code by using method hiding concept.
        {
            Console.WriteLine("child test2 is called.");
        }
        static void Main()
        {
            childs c = new childs();
            c.test1();                                  //run test1 of child because (overriding).
            c.test2();                                  //run test2 of child because (method hiding).
            c.ak();                                     //can use parents test1 even if override.
            c.hs();                                     //can use parents test1 even if method hiding.
            c.test3();                                  //run parents test3 (inheritance).
            c.test4();                                  //run parents test4 (inheritance).
            //parents p = new parents();                //instance creation of parents.
            //p.test1();                                  //run parents test1,not child test1
            //p.test2();                                  //run parents test2,not child test2
            //p.test3();                                  //run parents test3,not child test3
            //p.test4();                                  //run parents test4,not child test4
            parents p;                                    //variable of class parents
            p = c;                                        //variable initialization by child instance(reference)
            p.test1();                                    //child test1 is call because it is override.(accesible only by parents references)
            //p.ak();                                     //p no access c method(error).
            p.test2();                                    //parent test2 is call because it is method hiding.
            p.test3();                                    //run parents test3 because p can,t access child methd.
            Console.ReadLine();
        }
    }
}
