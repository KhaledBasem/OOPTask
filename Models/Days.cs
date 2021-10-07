using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OOPTask1.Models
{
    public class Days : HourDay
    {
        int day;
        double dayprice;

        public int _Day
        {
            set { day = value; }
            get { return day; }
        }
        public double _DayPrice
        {
            set { dayprice = value; }
            get { return dayprice; }
        }

        public override bool check()
        {
            if (fname != " " && lname != " " && Email != " " && day != 0 && dayprice != 0 && phone != " ") 
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
            double salary= (day * dayprice);
            return salary;
        }


    }
}
