using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MethodOver
    {
        public void addision()
        {
            Console.WriteLine("please pass parameter to add");
            Console.ReadLine();
        }
        public string addision(string a,string b)
        {
            return a + b;
        }
        public string addision(string a, int b)
        {
            return a + b;
        }
        public string addision(string a, float b)
        {
            return a + b;
        }
        public int addision(int a, int b)
        {
            return a + b;
        }
        public string addision(int a, string b)
        {
            return a + b;
        }
        public float addision(int a, float b)
        {
            return a + b;
        }
        public float addision(float a, int b)
        {
            return a + b;
        }
        public float addision(float a, float b)
        {
            return a + b;
        }
        public string addision(float a, string b)
        {
            return a + b;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] arg)
        {
            MethodOver obj = new MethodOver();
             var x=obj.addision(10, "ahmad");  //it react on the baasic of user parameter.it overcome on the problem of defining different different method for different -different addditon
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
