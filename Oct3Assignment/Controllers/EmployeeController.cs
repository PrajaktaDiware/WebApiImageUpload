using Oct3Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Oct3Assignment.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmployeeController : ApiController
    {
        StudentContext db = new StudentContext();

        // GET: api/Employee
        public IHttpActionResult Get()
        {
            var res=db.Employes.ToList();
            return Ok(res);
        }

        // GET: api/Employee/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Employee
        public IHttpActionResult Post(Employe emp)
        {
            db.Employes.Add(emp);
            db.SaveChanges();
            return Ok("Ok");
        }

        // PUT: api/Employee/5
        
        public IHttpActionResult Put(Employe value)
        {
            var res = db.Employes.Find(value.Id);
            res.Email = value.Email;
            res.DOB = value.DOB;
            res.Image = value.Image;        
            db.SaveChanges();
            return Ok("Ok");

        }

        // DELETE: api/Employee/5
        public IHttpActionResult Delete(int id)
        {
            var res = db.Employes.Find(id);
            db.Employes.Remove(res);
            db.SaveChanges();
            return Ok("ok");

        }
    }
}
