using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPTask1.Models
{
    public class Doctor : AllEmployee
    {


        public override double Tax(double salary)
        {
            double TaxSalary = 0;
            if (salary <= 500)
            {
                TaxSalary = salary * 0.05;
            }
            else if (salary > 500 && salary < 750)
            {
                TaxSalary = salary * 0.075;
            }
            else if (salary >= 750)
            {
                TaxSalary = salary * 0.010;
            }

            double NetSalary = salary - TaxSalary;
            return NetSalary;
        }
        public override double Social(double salary)
        {
            double SocialSecurtiy = 0;
            if (gender == "MR")
            {
                if (salary > 260 && salary < 500)
                {
                    SocialSecurtiy = salary - 30;
                }
                else if (salary > 500)
                {
                    SocialSecurtiy = salary - 45;
                }
            }

            else if (gender== "MS")
            {
                if (salary < 260 && salary < 500)
                {
                    SocialSecurtiy = salary - 35;
                }
                else if (salary > 500)
                {
                    SocialSecurtiy = salary - 50;
                }
            }

            var NewNetSalary = salary - SocialSecurtiy;

            return NewNetSalary;
        }

    }
}
