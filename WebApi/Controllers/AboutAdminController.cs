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
    public class AboutAdminController : ApiController
    {
        private AboutEntities db = new AboutEntities();

        // GET: api/AboutAdmin
        public IQueryable<About_ad> GetAbout_ad()
        {
            return db.About_ad;
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
            return db.About_ad.Count(e => e.Email == id) > 0;
        }
    }
}