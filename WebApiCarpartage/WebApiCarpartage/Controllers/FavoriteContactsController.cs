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
    public class FavoriteContactsController : ApiController
    {
        private WebApiCarpartageContext db = new WebApiCarpartageContext();

        // GET: api/FavoriteContacts
        public IQueryable<FavoriteContact> GetFavoriteContacts()
        {
            return db.FavoriteContacts;
        }

        // GET: api/FavoriteContacts/5
        [ResponseType(typeof(FavoriteContact))]
        public IHttpActionResult GetFavoriteContact(int id)
        {
            FavoriteContact favoriteContact = db.FavoriteContacts.Find(id);
            if (favoriteContact == null)
            {
                return NotFound();
            }

            return Ok(favoriteContact);
        }

        // PUT: api/FavoriteContacts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFavoriteContact(int id, FavoriteContact favoriteContact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != favoriteContact.Id)
            {
                return BadRequest();
            }

            db.Entry(favoriteContact).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FavoriteContactExists(id))
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

        // POST: api/FavoriteContacts
        [ResponseType(typeof(FavoriteContact))]
        public IHttpActionResult PostFavoriteContact(FavoriteContact favoriteContact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.FavoriteContacts.Add(favoriteContact);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = favoriteContact.Id }, favoriteContact);
        }

        // DELETE: api/FavoriteContacts/5
        [ResponseType(typeof(FavoriteContact))]
        public IHttpActionResult DeleteFavoriteContact(int id)
        {
            FavoriteContact favoriteContact = db.FavoriteContacts.Find(id);
            if (favoriteContact == null)
            {
                return NotFound();
            }

            db.FavoriteContacts.Remove(favoriteContact);
            db.SaveChanges();

            return Ok(favoriteContact);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FavoriteContactExists(int id)
        {
            return db.FavoriteContacts.Count(e => e.Id == id) > 0;
        }
    }
}