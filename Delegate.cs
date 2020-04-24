using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public delegate void Sumnum(int a, int b);              //defining delegate
    public delegate string swagat(string name);             //no need to static in delegate.
    class Delegate
    {
        public void Addnum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static string welcome(string name)
        {
            return "hello " + name;
        }
        static void Main()
        {
            Delegate obj = new Delegate();
            //obj.Addnum(100, 50);
            Sumnum sn = new Sumnum(obj.Addnum);             //intancetiating delegate
            sn.Invoke(100, 50);                             //calling using delegate
            swagat sw = new swagat(welcome);
            string a = sw.Invoke("altakba");
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
