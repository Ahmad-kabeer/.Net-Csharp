using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public class Emp
    {
        int Eno;
        string Ename;
        string Job;
        double Salary;
        string Post;
        static bool Status = false;
        public Emp(int Eno,string Ename,string Job,double Salary,string Post)
        {
            this.Eno = Eno;
            this.Ename = Ename;
            this.Job = Job;
            this.Salary = Salary;
            this.Post = Post;
        }
        public object this[int index]
        {
            get
            {
                if (index == 1)
                    return Eno;
                else if (index == 2)
                    return Ename;
                else if (index == 3)
                    return Job;
                else if (index == 4)
                    return Salary;
                else if (index == 5)
                    return Post;
                return null;
            }
            set
            {
                if (index == 1)
                    Eno = (int)value;
                if (index == 2)
                    Ename = (string)value;
                if (index == 3)
                    Job = (string)value;
                if (index == 4)
                    Salary = (double)value;
                if (index == 5)
                    Post = (string)value;
            }
        }
    }
    public class TestEmp : Emp
    {
        public TestEmp():base(101, "ahmad", "engineer", 10000, "senior")
        {

        }
        static void Main()
        {
            Emp obj = new Emp(101, "ahmad", "engineer", 10000, "senior");
            //TestEmp obj1 = new TestEmp();
            Console.WriteLine(obj[1]);
            Console.WriteLine(obj[2]);
            Console.WriteLine(obj[3]);
            Console.WriteLine(obj[4]);
            Console.WriteLine(obj[5]);

            obj[1] = 102;
            Console.WriteLine("\n" + obj[1]);
            obj[2] = "kabeer";
            Console.WriteLine(obj[2]);
            obj[3] = "doctor";
            Console.WriteLine(obj[3]);
            obj[4] = 12000.0;
            Console.WriteLine(obj[4]);
            obj[5] = "TopDoctor";
            Console.WriteLine(obj[5]);
            Console.ReadLine();
        }
    }
}
