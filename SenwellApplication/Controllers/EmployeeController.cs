using SenwellApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SenwellApplication.Controllers
{
    public class EmployeeController : ApiController
    {
        public SenwellEntities _db = new SenwellEntities();

        [HttpGet]
        public IHttpActionResult GetEmployeeById(int id)
        {
            var Data = _db.Tasks.FirstOrDefault(x => x.employee_id == id);
            return Ok(Data);

        }
        [HttpGet]
        public IHttpActionResult GetEmployeeByDept(string department)
        {
            var Data = _db.Tasks.FirstOrDefault(x => x.department == department);
            return Ok(Data);

        }
        [HttpGet]
        public IHttpActionResult GetEmployeeBySalary(int s)
        {
            var Data = _db.Tasks.FirstOrDefault(x => x.salary == s);
            return Ok(Data);

        }



    }
}
