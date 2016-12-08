using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Modeles;
using WebApiCarpartage.Models;

namespace WebApiCarpartage.Controllers
{
    public class PostPassengersController : ApiController
    {
        private WebApiCarpartageContext db = new WebApiCarpartageContext();

        // GET: api/PostPassengers
        public IQueryable<PostPassenger> GetPostPassengers()
        {
            return db.PostPassengers;
        }

        // GET: api/PostPassengers/5
        [ResponseType(typeof(PostPassenger))]
        public IHttpActionResult GetPostPassenger(int id)
        {
            PostPassenger postPassenger = db.PostPassengers.Find(id);
            if (postPassenger == null)
            {
                return NotFound();
            }

            return Ok(postPassenger);
        }

        // PUT: api/PostPassengers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPostPassenger(int id, PostPassenger postPassenger)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != postPassenger.Id)
            {
                return BadRequest();
            }

            db.Entry(postPassenger).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostPassengerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/PostPassengers
        [ResponseType(typeof(PostPassenger))]
        public IHttpActionResult PostPostPassenger(PostPassenger postPassenger)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PostPassengers.Add(postPassenger);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = postPassenger.Id }, postPassenger);
        }

        // DELETE: api/PostPassengers/5
        [ResponseType(typeof(PostPassenger))]
        public IHttpActionResult DeletePostPassenger(int id)
        {
            PostPassenger postPassenger = db.PostPassengers.Find(id);
            if (postPassenger == null)
            {
                return NotFound();
            }

            db.PostPassengers.Remove(postPassenger);
            db.SaveChanges();

            return Ok(postPassenger);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PostPassengerExists(int id)
        {
            return db.PostPassengers.Count(e => e.Id == id) > 0;
        }
    }
}