using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public class pa
    {
        int _Cid;                                   //underscope means this variable consist its own property of get and set.
        bool _Status;
        string _name;
        double _Balance;
        cities _city;                               //variable of enum cities. this enum contain several city name
        public pa(int Cid, bool Status, string name, double Balance, cities city)        //constructor
        {
            _Cid = Cid;
            _Status = Status;
            _name = name;
            _Balance = Balance;
            _city = city;
        }
        public int Cid              //property
        {
            get
            {
                return _Cid;
            }
            set
            {
                if (_Status == true)
                {
                    _Cid = value;
                }
                
            }
        }
        public bool Status
        {
            get
            {
                return _Status;
            }
            set
            {
                _Status = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_Status==true)
                {
                    _name = value;
                }
                
            }
        }
        public double Balance
        {
            get
            {
                return _Balance;
            }
            set
            {
                if (_Status == true)                //condition before assign new value
                {
                    if (value >= 500)
                    {
                        _Balance = value;
                    }
                }
                
            }
        }
        public cities city
        {
            get { return _city; }
            protected set                           //accesible only for child class
            {
                if (_Status == true)
                {
                    _city = value;
                }
                
            }

        }

        //property without variable .(automatic property or automatic implementation)introduce  in C# ver--3.0
        //property without variable .(auto property initializer)introduce in C# ver--6.0
        public string country              
        {
            get;
            //set;                  //no for set.only for get
        } = "india";
    }
    class chi
     {
        static void Main()
        {
            pa obj = new pa(102, false, "kabeer", 5000, cities.amroha);
            Console.WriteLine("status= " + obj.Status);
            Console.WriteLine("id= "+obj.Cid);
            Console.WriteLine("name= " +obj.Name);
            obj.Status = true;                      //set status as true
            Console.WriteLine("status= " + obj.Status);
            obj.Balance -= 3000;                    //deduct some balance
            Console.WriteLine(obj.Balance);
            obj.Balance = obj.Balance - 1600;           //fail b/c this deduct more balance
            Console.WriteLine(obj.Balance);
            Console.WriteLine("current city=" + obj.city);
            //obj.city = cities.pakbara;                //can't modify due to protection
            Console.WriteLine("modify city=" + obj.city);
            Console.WriteLine("country= "+obj.country);
            Console.ReadLine();
        }
    }
    class chi1 : pa
    {
        public chi1() : base(102, false, "kabeer", 5000, cities.amroha)
        {

        }
        static void Main()
        {
            chi1 obj = new chi1(/*101, false, "ahmad", 5000, cities.amroha*/);
            Console.WriteLine("status= " + obj.Status);
            Console.WriteLine("name="+ obj.Cid);
            obj.Status = true;                      //set status as true
            Console.WriteLine("status= " + obj.Status);
            obj.Balance -= 3000;                    //deduct some balance
            Console.WriteLine("balance="+obj.Balance);
            obj.Balance = obj.Balance - 1600;           //fail b/c this deduct more balance
            Console.WriteLine("balance=" + obj.Balance);
            Console.WriteLine("current city=" + obj.city);
            obj.city = cities.moradabad;                //can modify only by child class
            Console.WriteLine("modify city=" + obj.city);
            Console.ReadLine();
        }
    }
}
