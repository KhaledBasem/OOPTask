using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPTask1.Models
{
    public abstract class HourDay
    {

        protected String fname;
        protected String lname;
        protected String Email;
        protected String phone;

        public String _Fname
        {
            set { fname = value; }
            get { return fname; }
        }
        public String _Lname
        {
            set { lname = value; }
            get { return lname; }
        }
        public String _Email
        {
            set { Email = value; }
            get { return Email; }
        }
        public String _Phone
        {
            set { phone = value; }
            get { return phone; }
        }
        public abstract bool check();
        public abstract double Cal();

        public String print1(double salary, String typeoflist)
        {
            String msg = " Hello " + fname + " " + lname  + " this is " + typeoflist + " Emoloyee ,your salay is :" + salary;
            return msg;
        }




    }
}
