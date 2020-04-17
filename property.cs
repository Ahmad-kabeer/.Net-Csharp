using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public class pa
    {
        int _Cid;                   //underscope means this variable consist its own property of get and set.
        bool _Status;
        string _name;
        double _Balance;
        public pa(int _Cid, bool _Status, string _name, double _Balance)        //constructor
        {
            this._Cid = _Cid;
            this._Status = _Status;
            this._name = _name;
            this._Balance = _Balance;
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
    }       
    class chi
    {
        static void Main()
        {
            pa obj = new pa(101,false,"ahmad",5000);
            Console.WriteLine(obj.Cid);
            obj.Status = true;                      //set status as true
            obj.Balance -= 3000;                    //deduct some balance
            Console.WriteLine(obj.Balance);
            obj.Balance = obj.Balance - 1600;           //fail b/c this deduct more balance
            Console.WriteLine(obj.Balance);
            Console.ReadLine();
        }
    }
}
