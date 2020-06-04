using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    static class ExtensionClass
    {
        public static string ToProper(this string OldStr)
        {
            string NewStr = null;
            if (OldStr.Trim().Length > 0)
            {
                string a= OldStr.ToLower();
                string[] b = a.Split(' ');
                foreach(string i in b)
                {
                    char[] c = i.ToCharArray();
                    c[0] = char.ToUpper(c[0]);
                    if (NewStr == null)
                    {
                        NewStr = new string(c);
                    }
                    else
                    {
                        NewStr += " " + new string(c);
                    }
                }
                return NewStr;
            }
            else
            {
                Console.WriteLine("please putt some string");
                return OldStr;
            }
        }

    }
    class TestExtension
    {
        static void Main()
        {
            string ak = "zsjdjJ ASNBvxsabc cbN nsb jsd jncj UM JNbj JNM j JB j ADJD CNDSC DSdsh DCMkjnLDX sdks cdkn san";
            var d = ak.ToProper();
            Console.WriteLine(d);
            Console.ReadLine();

        }
    }
}
