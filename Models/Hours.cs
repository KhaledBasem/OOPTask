using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPTask1.Models
{
    public class Hours : HourDay
    {
        double hour;
        double hourprice;

        public double _Hour
        {
            set { hour = value; }
            get { return hour; }
        }
        public double _HourPrice
        {
            set { hourprice = value; }
            get { return hourprice; }
        }

        public override bool check()
        {
            if (fname != " " && lname != " " && Email != " " && hour != 0 &&  hourprice != 0 && phone != " ")
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public override double Cal()
        {
            double salary = (hour * hourprice);
            return salary;
        }
    }
}
