using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace project1
{
    class OperatorOverlo
    {
        public override string ToString()
        {
            return a + " " + b + "\n" + c + " " + d + "\n";
        }
        int a, b, c, d;
        public OperatorOverlo(int a,int b,int c,int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public static OperatorOverlo operator +(OperatorOverlo obj1,OperatorOverlo obj2)
        {
            OperatorOverlo obj = new OperatorOverlo(obj1.a + obj2.a, obj1.b + obj2.b, obj1.c + obj2.c, obj1.d + obj2.d);
            return obj;
        }
        static void Main()
        {
            OperatorOverlo m1 = new OperatorOverlo(10, 20, 30, 40);
            OperatorOverlo m2 = new OperatorOverlo(10, 20, 30, 40);
            OperatorOverlo m3 = new OperatorOverlo(10, 20, 30, 40);
            OperatorOverlo m4 = m1 + m2 + m3;
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);
            Console.ReadLine();
        }
    }
}
