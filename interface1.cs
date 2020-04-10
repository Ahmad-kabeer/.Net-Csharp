using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    interface interface1
    {
        int Add(int a,int b);
        
    }
    interface interface2 : interface1               //inherit
    {
        int Sub(int c, int d);
    }
    class ahmad : interface2
    {
        public int Add(int a,int b)             //may use alternative option i.e(  int interface1.Add(int a,int b){--}  )
        {
            return a + b;
        }
        int interface2.Sub(int c, int d)        //alternative to define body of method,no need to override keyword.
        {
            return c - d;
        }
        static void Main()
        {
            ahmad ah = new ahmad();
            //ah.Add(2, 2);
            //ah.Sub(2, 2);                     //can't access because it is private.
            interface1 i1 = ah;                 //reference of interface1 by object of ahmad
            Console.WriteLine(i1.Add(2, 2));
            //i1.Sub(2, 2);                     //error
            interface2 i2 = ah;                 //reference of interface2 by object of ahmad
            Console.WriteLine(i2.Add(2, 2));
            Console.WriteLine(i2.Sub(2, 2));                       //i2 can access on both OK.
            Console.ReadLine();
        }
    }
}
