using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace project1
{
    class matrixmul
    {
        public override string ToString()
        {
            return a + " " + b + "\n" + c + " " + d + "\n";
        }
        int a, b, c, d;
        public matrixmul(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public static matrixmul operator *(matrixmul obj1, matrixmul obj2)
        {
            
            matrixmul obj = new matrixmul((obj1.a*obj2.a) +(obj1.b*obj2.c) , (obj1.a * obj2.b) + (obj1.b * obj2.d), (obj1.c * obj2.a) + (obj1.d * obj2.c), (obj1.c * obj2.b) + (obj1.d * obj2.d));
            return obj;
        }
        static void Main()
        {
            matrixmul m1 = new matrixmul(2,3,4,5);
            matrixmul m2 = new matrixmul(6,7,8,9);
            //matrixmul m3 = new matrixmul(10, 20, 30, 40);
            matrixmul m4 = m1 * m2;
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            //Console.WriteLine(m3);
            Console.WriteLine(m4);
            Console.ReadLine();
        }
    }
}
