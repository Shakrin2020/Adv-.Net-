using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabTask_1.Models;
using System.Data.SqlClient;

namespace LabTask_1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Student()); // first when load ta form, it will have e null model bcz value ="@Model.Name" is already setted
        }

        [HttpPost]
        public ActionResult Create(Student s)
        {
            if (ModelState.IsValid)   // form validation
            {
                string connString = "";
                SqlConnection conn = new SqlConnection(connString);  // parameter: connection string

                conn.Open();

                string query = "";

                SqlCommand cmd = new SqlCommand(query, conn);  // parameter: query and connection

                cmd.ExecuteNonQuery();
                
                return RedirectToAction("List", "Person");  // if different controller, then 1st mention action then controller
            }
            return View(s);
        }

        [HttpPost]
        public ActionResult Submit(Student s)
        {
            //ViewBag.Name = Request["Name"];    //without creating class

            /////       1        /////

            /*Student s = new Student();

              s.Name = Request["Name"];
              s.Id= Request["Id"];               // 1st approach // request contains others info also, like server etc
              s.Dob = Request["Dob"];
              s.Email = Request["Email"];*/

            /////       2       /////

            /* public ActionResult Submit(FormCollection form)

             Student s = new Student();

             s.Name = form["Name"];
             s.Id = form["Id"];                   // 2nd approach // only cointains form info
             s.Dob = form["Dob"];
             s.Email = form["Email"];

             return View(s);*/

            /////       3        /////

            /* public ActionResult Submit(string Name, string Id, string Dob, string Email ) 
             
           { Student s = new Student();

            s.Name = Name;
            s.Id = Id;                          // 3rd approach // using parameter
            s.Dob = Dob;
            s.Email = Email;

            return View(s);
            }
            */

            /////       4       /////
            
            return View  (s);                  // 4th approach // using class-object (Model-Based approach)

        }
    }
}