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
    public class FavoriteMarketsController : ApiController
    {
        private WebApiCarpartageContext db = new WebApiCarpartageContext();

        // GET: api/FavoriteMarkets
        public IQueryable<FavoriteMarket> GetFavoriteMarkets()
        {
            return db.FavoriteMarkets;
        }

        // GET: api/FavoriteMarkets/5
        [ResponseType(typeof(FavoriteMarket))]
        public IHttpActionResult GetFavoriteMarket(int id)
        {
            FavoriteMarket favoriteMarket = db.FavoriteMarkets.Find(id);
            if (favoriteMarket == null)
            {
                return NotFound();
            }

            return Ok(favoriteMarket);
        }

        // PUT: api/FavoriteMarkets/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFavoriteMarket(int id, FavoriteMarket favoriteMarket)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != favoriteMarket.Id)
            {
                return BadRequest();
            }

            db.Entry(favoriteMarket).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FavoriteMarketExists(id))
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

        // POST: api/FavoriteMarkets
        [ResponseType(typeof(FavoriteMarket))]
        public IHttpActionResult PostFavoriteMarket(FavoriteMarket favoriteMarket)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.FavoriteMarkets.Add(favoriteMarket);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = favoriteMarket.Id }, favoriteMarket);
        }

        // DELETE: api/FavoriteMarkets/5
        [ResponseType(typeof(FavoriteMarket))]
        public IHttpActionResult DeleteFavoriteMarket(int id)
        {
            FavoriteMarket favoriteMarket = db.FavoriteMarkets.Find(id);
            if (favoriteMarket == null)
            {
                return NotFound();
            }

            db.FavoriteMarkets.Remove(favoriteMarket);
            db.SaveChanges();

            return Ok(favoriteMarket);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FavoriteMarketExists(int id)
        {
            return db.FavoriteMarkets.Count(e => e.Id == id) > 0;
        }
    }
}