using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabTask_1.Models;     // if we want to use the class, have to include it

namespace LabTask_1.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Home()
        {
            /*ViewBag.Name = "Anushesh";
            ViewBag.Id = 124;
            ViewData["Dob"] = DateTime.Now;   //using dictionary // as php associative array */

            Person p = new Person();

            p.Name = "Anushesh";
            p.Id = 124;
            p.Dob = DateTime.Now;

            return View(p);   // pass the object as the parameter of view
        }

        public ActionResult List()
        {
            /*string [] names = { "Sadia", "Riya", "Sumona", "Sakib", "Ariyan" };
            ViewBag.Names = names; */

            List <Person> persons = new List <Person> ();

            for (int i = 0; i < 100; i++)
            {
                var p = new Person
                {
                    Id = i + 1,
                    Name = "Person " + (i + 1),
                    Dob = DateTime.Now
                };

                persons.Add(p);
            }

            return View(persons);
        }
    }
}