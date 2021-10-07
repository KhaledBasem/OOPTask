using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPTask1.Models
{
    public class Teacher : AllEmployee
    {
        public double social;
       
        public override double Tax(double salary)
        {

            double TaxSalary = 0;
            if (salary > 500 && salary < 750)
            {
                TaxSalary = salary * 0.03;

            }
            else if (salary >= 750)
            {
                TaxSalary = salary * 0.05;
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
                    SocialSecurtiy = salary - 10;
                }
                else if (salary > 500)
                {
                    SocialSecurtiy = salary - 20;
                }
            }

            else if (gender== "MS")
            {
                if (salary < 260 && salary < 500)
                {
                    SocialSecurtiy = salary - 20;
                }
                else if (salary > 500)
                {
                    SocialSecurtiy = salary - 40;
                }
            }
            var NewNetSalary = salary - SocialSecurtiy;
            return NewNetSalary;
        }
    }
        
    }

