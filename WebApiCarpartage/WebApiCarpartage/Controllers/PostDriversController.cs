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
    public class PostDriversController : ApiController
    {
        private WebApiCarpartageContext db = new WebApiCarpartageContext();

        // GET: api/PostDrivers
        public IQueryable<PostDriver> GetPostDrivers()
        {
            return db.PostDrivers;
        }

        // GET: api/PostDrivers/5
        [ResponseType(typeof(PostDriver))]
        public IHttpActionResult GetPostDriver(int id)
        {
            PostDriver postDriver = db.PostDrivers.Find(id);
            if (postDriver == null)
            {
                return NotFound();
            }

            return Ok(postDriver);
        }

        // PUT: api/PostDrivers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPostDriver(int id, PostDriver postDriver)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != postDriver.Id)
            {
                return BadRequest();
            }

            db.Entry(postDriver).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostDriverExists(id))
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

        // POST: api/PostDrivers
        [ResponseType(typeof(PostDriver))]
        public IHttpActionResult PostPostDriver(PostDriver postDriver)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PostDrivers.Add(postDriver);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = postDriver.Id }, postDriver);
        }

        // DELETE: api/PostDrivers/5
        [ResponseType(typeof(PostDriver))]
        public IHttpActionResult DeletePostDriver(int id)
        {
            PostDriver postDriver = db.PostDrivers.Find(id);
            if (postDriver == null)
            {
                return NotFound();
            }

            db.PostDrivers.Remove(postDriver);
            db.SaveChanges();

            return Ok(postDriver);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PostDriverExists(int id)
        {
            return db.PostDrivers.Count(e => e.Id == id) > 0;
        }
    }
}