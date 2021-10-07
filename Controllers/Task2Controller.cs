using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOPTask1.Models;

namespace OOPTask1.Controllers
{
    public class Task2Controller : Controller
    {
        public IActionResult Index()
        {
            return View("Situation");
        }

        public IActionResult Index1()
        {
            
            var typeoflist = Request.Form["Are You"];
            String gender = Request.Form["gender"];
            if (typeoflist == "Doctor")
            {
                Doctor doctor = new Doctor();

                doctor._FirsName = Request.Form["textFirst"];
                doctor._LastName = Request.Form["textLast"];
                doctor._Salary =Convert.ToDouble( Request.Form["Salary"]);
                doctor._Deduction = Convert.ToDouble(Request.Form["Deduction"]);
                doctor._Ins = Convert.ToDouble(Request.Form["Insentive"]);
                doctor._gender = Request.Form["gender"];

                bool isValid = doctor.check();
                doctor.CalSalary();


                if (isValid == true)


                {

                    double salary = doctor.CalSalary();
                    double NewSal = doctor.Tax(salary);
                    if (NewSal >= 250)
                    {
                        double y = doctor.Social(NewSal);
                        String msg = doctor.Print(y, salary);
                        ViewData["Message"] = msg;
                    }
                    else if (NewSal < 260)
                    {
                        ViewData["Msg"] = doctor.Print(salary);
                    }
                    else
                    {
                        ViewData["Msg"] = doctor.Print();

                    }

                }


            }
            if (typeoflist == "Teacher")
            {
                Teacher teacher = new Teacher();

                teacher._FirsName = Request.Form["textFirst"];
                teacher._LastName = Request.Form["textLast"];
                teacher._Salary = Convert.ToDouble(Request.Form["Salary"]);
                teacher._Deduction = Convert.ToDouble(Request.Form["Deduction"]);
                teacher._Ins = Convert.ToDouble(Request.Form["Insentive"]);
                teacher._gender = Request.Form["gender"];

                bool isValid = teacher.check();
                teacher.CalSalary();


                if (isValid == true)


                {
                   
                        double salary = teacher.CalSalary();
                       double NewSal= teacher.Tax(salary);
                    if (NewSal >= 250)
                    {
                        double y = teacher.Social(NewSal);
                        String msg = teacher.Print(y, salary);
                        ViewData["Message"] = msg;
                    }
                    else if (NewSal < 260)
                    {
                        ViewData["Msg"] = teacher.Print(salary);
                    }
                    else
                    {
                        ViewData["Msg"] = teacher.Print();

                    }
                }
                    

                


            }
            if (typeoflist == "Engineer")
            {
                Engineer engineer = new Engineer();

                engineer._FirsName = Request.Form["textFirst"];
                engineer._LastName = Request.Form["textLast"];
                engineer._Salary = Convert.ToDouble(Request.Form["Salary"]);
                engineer._Deduction = Convert.ToDouble(Request.Form["Deduction"]);
                engineer._Ins = Convert.ToDouble(Request.Form["Insentive"]);
                engineer._gender = Request.Form["gender"];

                bool isValid = engineer.check();
                engineer.CalSalary();


                if (isValid == true)


                {

                    double salary = engineer.CalSalary();
                    double NewSal = engineer.Tax(salary);
                    if (NewSal >= 250)
                    {
                        double y = engineer.Social(NewSal);
                        String msg = engineer.Print(y, salary);
                        ViewData["Message"] = msg;
                    }
                    else if (NewSal < 260)
                    {
                        ViewData["Msg"] = engineer.Print(salary);
                    }
                    else
                    {
                        ViewData["Msg"] = engineer.Print();

                    }
                }


            }
            return View("Situation");
        }

    }
}
