using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPTask1.Models
{
    public class Engineer : AllEmployee
    {
        double social;
       
        public override double Tax(double salary)
        {

            double TaxSalary = 0;

            if (salary <= 500)
            {
                TaxSalary = salary * 0.025;
            }
            else if (salary > 500 && salary < 750)
            {
                TaxSalary = salary * 0.05;
            }
            else if (salary >= 750)
            {
                TaxSalary = salary * 0.075;
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
                    SocialSecurtiy = salary - 15;
                }
                else if (salary > 500)
                {
                    SocialSecurtiy = salary - 35;
                }
            }

            else if (gender == "MR")
            {
                if (salary < 260 && salary < 500)
                {
                    SocialSecurtiy = salary - 32;
                }
                else if (salary > 500)
                {
                    SocialSecurtiy = salary - 51;
                }
            }
            var NewNetSalary = salary - SocialSecurtiy;
            return NewNetSalary;
        }

    }

    }

