using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOPTask1.Models;

namespace OOPTask1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View("Info");
        }

        public IActionResult Index1()
        {
            var typeoflist = Request.Form["typelist"];
            if (typeoflist == "Hourly")
            {
                Hours h = new Hours();

                h._Fname = Request.Form["textFirst"];
                h._Lname = Request.Form["textLirst"];
                h._Email = Request.Form["textEmail"];
                h._Phone = Request.Form["textPhone"];
                h._Hour = Convert.ToDouble(Request.Form["textHours"]);
                h._HourPrice = Convert.ToDouble(Request.Form["texthp"]);

                bool isValid = h.check();
                h.Cal();

                if (isValid == true)

                {

                    double salary = h.Cal();
                    String msg = h.print1(salary,typeoflist);
                    ViewData["Message"] = msg;

                }


            }
            else
 
                {
                    Days d = new Days();
                    d._Fname = Request.Form["textFirst"];
                    d._Lname = Request.Form["textLast"];
                    d._Email = Request.Form["textEmail"];
                    d._Phone = Request.Form["textPhone"];
                    d._Day = Convert.ToInt32(Request.Form["textDays"]);
                    d._DayPrice = Convert.ToDouble(Request.Form["textdp"]);


                    bool isValid = d.check();
                    d.Cal();

                    if (isValid == true)
                    {

                        double salary = d.Cal();
                        String msg = d.print1(salary, typeoflist);
                        ViewData["Message"] = msg;

                    }

                }


                return View("Info");



            }

        }
    }



