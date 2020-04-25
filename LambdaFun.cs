using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public delegate string DelLambda(string a);
    class LambdaFun
    {

        static void Main()
        {
            DelLambda obj = (name) =>
            {
                return "hello " + name + " is a good men.";
            };
            var b = obj.Invoke("khansab");
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
