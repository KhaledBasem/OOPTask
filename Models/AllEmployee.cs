using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPTask1.Models
{
    public abstract class AllEmployee
    {
        protected String firstname;
        protected String lastname;
        protected double salay;
        protected double deduction;
        protected double insentive;
        public double NewSalary;
        protected String gender;
        


        public String _FirsName
        {
            set { firstname = value; }
            get { return firstname; }
        }
        public String _gender
        {
            set { gender = value; }
            get { return gender; }
        }


        public String _LastName
        {
            set { lastname = value; }
            get { return lastname; }
        }

        public double _Salary
        {
            set { salay = value; }
            get { return salay; }
        }

        public double _Deduction
        {
            set { deduction = value; }
            get { return deduction; }
        }

        public double _Ins
        {
            set { insentive = value; }
            get { return insentive; }
        }

        public  bool check()
        {
            if (firstname != " " && lastname != " " && salay >200 && deduction != 0 && insentive != 0)
            {
                return true;

            }
            else
            {
                return false;
            }

        }

       public double Sal;
  
        public double CalSalary()
        {
             Sal = salay - (deduction + insentive);
            return Sal;
        }
        public abstract double Tax(double salary);

        public abstract double Social(double salary);





        public string Print(double NewNewSalary, double TotalSalary)
        {
            return "Hello, You Completed The Reqistration From Successfully, Mr." + firstname + " " +lastname + "  We Will Deduct From Your Salary : " + NewNewSalary + " JD, Your Salary After Deduct : " + TotalSalary;
        }

        public string Print()
        {
            return "Please Enter & Fill This Info : Enter Your First Name.. , Enter Your Last Name.. , Your Salary Should More Than 200 JD";
        }

        public string Print(double TotalSalary)
        {
            return "Sorry! You Cannot Join With Us. " +
                " Tax Applied On Your Salary : " + TotalSalary + ", Your Salary After Tax & Deductions : 260 JD";
        }


    }
}
