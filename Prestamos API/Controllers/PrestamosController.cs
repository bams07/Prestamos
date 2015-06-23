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
using Prestamos_API.Models;

namespace Prestamos_API.Controllers
{
    public class PrestamosController : ApiController
    {
        private PContext db = new PContext();

        // GET api/Prestamos
        public IQueryable<prestamos> Getprestamos()
        {
            return db.prestamos;
        }

        // GET api/Prestamos/5
        [ResponseType(typeof(prestamos))]
        public IHttpActionResult Getprestamos(int id)
        {
           prestamos prestamos = db.prestamos.Find(id);

            db.prestamos_cuotas.ToList();


            if (prestamos == null)
            {
                return NotFound();
            }

            return Ok(prestamos);
        }

        // PUT api/Prestamos/5
        public IHttpActionResult Putprestamos(int id, prestamos prestamos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != prestamos.id)
            {
                return BadRequest();
            }

            db.Entry(prestamos).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!prestamosExists(id))
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

        // POST api/Prestamos
        [ResponseType(typeof(prestamos))]
        public IHttpActionResult Postprestamos(prestamos prestamos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.prestamos.Add(prestamos);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = prestamos.id }, prestamos);
        }

        // DELETE api/Prestamos/5
        [ResponseType(typeof(prestamos))]
        public IHttpActionResult Deleteprestamos(int id)
        {
            prestamos prestamos = db.prestamos.Find(id);
            if (prestamos == null)
            {
                return NotFound();
            }

            db.prestamos.Remove(prestamos);
            db.SaveChanges();

            return Ok(prestamos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool prestamosExists(int id)
        {
            return db.prestamos.Count(e => e.id == id) > 0;
        }
    }
}