using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APIassignment.Models.Database;

namespace APIassignment.Controllers
{
    public class StudentController : ApiController
    {
        // GET api/<controller>

        [Route("api/get/student")]
        [HttpGet]
        public List<Student> Get()
        {
            apidbEntities db = new apidbEntities();

            var students = new List <Student>();

            foreach (var s in db.Students)
            {
                var stu = new Student()
                {
                    S_Id = s.S_Id,
                    S_Name = s.S_Name,
                    S_Dob = s.S_Dob,
                };

                students.Add(stu);
            }
           
            return students;
        }
       
        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}