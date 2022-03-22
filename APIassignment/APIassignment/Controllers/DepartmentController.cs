using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APIassignment.Models.Database;

namespace APIassignment.Controllers
{
    public class DepartmentController : ApiController
    {
        // GET api/<controller>
        [Route("api/get/dept")]
        [HttpGet]
        public List<Department> Get()
        {
            apidbEntities db = new apidbEntities();

            var depts = new List<Department>();

            foreach (var d in db.Departments)
            {
                var dt = new Department()
                {
                    D_Id = d.D_Id,
                    D_Name = d.D_Name,
                   
                };

                depts.Add(dt);
            }

            return depts;
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