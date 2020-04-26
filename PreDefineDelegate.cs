using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class PreDefineDelegate
    {
        //1-func
        //2-action
        //3-predicate
        static void Main()
        {
            Func<int, int,int,int> obj =(x,y,z)=>                   //return value
            {
                return x + y + z;
            };
            var a = obj.Invoke(2,2,2);
            Console.WriteLine(a);

            Action<int,int,int> obj1 = (p,q,r) =>                   //not return value
            {
                Console.WriteLine(p + q + r);
            };
            obj1.Invoke(3, 3, 3);

            Predicate<int> obj2 = (s)=>                             //return only bool vallue
               {
                if (s == 5)
                    return true;
                else
                    return false;
            };
            var d = obj2.Invoke(5);
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
