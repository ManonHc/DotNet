using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using Modeles;
using WebApiCarpartage.Models;

namespace WebApiCarpartage.Controllers
{
    public class FavoritePostsController : ApiController
    {
        private WebApiCarpartageContext db = new WebApiCarpartageContext();

        // GET: api/FavoritePosts
        public IQueryable<FavoritePost> GetFavoritePosts()
        {
            return db.FavoritePosts;
        }

        // GET: api/FavoritePosts/5
        [ResponseType(typeof(FavoritePost))]
        public IHttpActionResult GetFavoritePost(bool id)
        {
            FavoritePost favoritePost = db.FavoritePosts.Find(id);
            if (favoritePost == null)
            {
                return NotFound();
            }

            return Ok(favoritePost);
        }

        // PUT: api/FavoritePosts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFavoritePost(bool id, FavoritePost favoritePost)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != favoritePost.Alert)
            {
                return BadRequest();
            }

            db.Entry(favoritePost).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FavoritePostExists(id))
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

        // POST: api/FavoritePosts
        [ResponseType(typeof(FavoritePost))]
        public IHttpActionResult PostFavoritePost(FavoritePost favoritePost)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.FavoritePosts.Add(favoritePost);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (FavoritePostExists(favoritePost.Alert))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = favoritePost.Alert }, favoritePost);
        }

        // DELETE: api/FavoritePosts/5
        [ResponseType(typeof(FavoritePost))]
        public IHttpActionResult DeleteFavoritePost(bool id)
        {
            FavoritePost favoritePost = db.FavoritePosts.Find(id);
            if (favoritePost == null)
            {
                return NotFound();
            }

            db.FavoritePosts.Remove(favoritePost);
            db.SaveChanges();

            return Ok(favoritePost);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FavoritePostExists(bool id)
        {
            return db.FavoritePosts.Count(e => e.Alert == id) > 0;
        }
    }
}