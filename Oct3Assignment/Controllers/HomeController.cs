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

    public class HomeController : ApiController
    { 
        StudentContext db= new StudentContext();
        // GET: api/Home
        public IHttpActionResult Get()
        {
             var res=db.PStudents.ToList();
            return Ok(res);
        }

        // POST: api/Home
        public IHttpActionResult Post(PStudent value)
        {
            db.PStudents.Add(value);
            db.SaveChanges();
            return Ok("Ok");
        }

        // PUT: api/Home/1
        public IHttpActionResult Put(PStudent value)
        {
            var res = db.PStudents.Find(value.Id);
            res.ChildFirstName = value.ChildFirstName;
            res.ChildLastName = value.ChildLastName;
            res.ChildGender = value.ChildGender;
            res.Address = value.Address;
            res.City = value.City;
            res.PostalCode = value.PostalCode;

            db.SaveChanges();
            return Ok("Ok");

        }

        // DELETE: api/Home/28


        //[HttpDelete]
        //[Route("api/Student/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var res = db.PStudents.Find(id);
            db.PStudents.Remove(res);
            db.SaveChanges();
            return Ok("ok");

        }
       
    }
}
