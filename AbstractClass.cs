using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public abstract class AbstractClass
    {
        public double length, width, height, radius;
        public const double pi = 3.14;
        public abstract double GetArea();
    }
    public class rectangle : AbstractClass
    {
        public rectangle(double length,double width)
        {
            this.length = length;
            this.width = width;
        }
        public override double GetArea()
        {
            return width * length;
        }
    }
    class triangel : AbstractClass
    {
        public triangel(double width,double height)
        {
            this.height = height;
            this.width = width;
        }
        public override double GetArea()
        {
            return (length * width) / 2;
        }
    }
    class child
    {
        static void Main(string[] arg)
        {
            rectangle rc = new rectangle(2, 5);
            triangel tr = new triangel(2, 5);
            Console.WriteLine("area of rectangle= "+rc.GetArea());
            Console.WriteLine("area of triangle= "+tr.GetArea());
            Console.ReadLine();
        }
    }
}
