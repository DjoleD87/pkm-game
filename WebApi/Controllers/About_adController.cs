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
using WebApi.Models;

namespace WebApi.Controllers
{
    public class About_adController : ApiController
    {
        private AbEntities db = new AbEntities();

        // GET: api/About_ad
        public IQueryable<About_ad> GetAbout_ad()
        {
            return db.About_ad;
        }

        // GET: api/About_ad/5
        [ResponseType(typeof(About_ad))]
        public IHttpActionResult GetAbout_ad(string id)
        {
            About_ad about_ad = db.About_ad.Find(id);
            if (about_ad == null)
            {
                return NotFound();
            }

            return Ok(about_ad);
        }

        // PUT: api/About_ad/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAbout_ad(string id, About_ad about_ad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != about_ad.F_name)
            {
                return BadRequest();
            }

            db.Entry(about_ad).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!About_adExists(id))
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

        // POST: api/About_ad
        [ResponseType(typeof(About_ad))]
        public IHttpActionResult PostAbout_ad(About_ad about_ad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.About_ad.Add(about_ad);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (About_adExists(about_ad.F_name))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = about_ad.F_name }, about_ad);
        }

        // DELETE: api/About_ad/5
        [ResponseType(typeof(About_ad))]
        public IHttpActionResult DeleteAbout_ad(string id)
        {
            About_ad about_ad = db.About_ad.Find(id);
            if (about_ad == null)
            {
                return NotFound();
            }

            db.About_ad.Remove(about_ad);
            db.SaveChanges();

            return Ok(about_ad);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool About_adExists(string id)
        {
            return db.About_ad.Count(e => e.F_name == id) > 0;
        }
    }
}