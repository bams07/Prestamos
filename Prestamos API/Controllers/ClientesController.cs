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
    public class ClientesController : ApiController
    {
        private PContext db = new PContext();

        // GET api/Clientes
        public IQueryable<clientes> Getclientes()
        {
            return db.clientes;
        }

        // GET api/Clientes/5
        [ResponseType(typeof(clientes))]
        public IHttpActionResult Getclientes(string id)
        {
            clientes clientes = db.clientes.Find(id);
            if (clientes == null)
            {
                return NotFound();
            }

            return Ok(clientes);
        }

        // PUT api/Clientes/5
        public IHttpActionResult Putclientes(string id, clientes clientes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != clientes.cedula)
            {
                return BadRequest();
            }

            db.Entry(clientes).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!clientesExists(id))
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

        // POST api/Clientes
        [ResponseType(typeof(clientes))]
        public IHttpActionResult Postclientes(clientes clientes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.clientes.Add(clientes);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (clientesExists(clientes.cedula))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = clientes.cedula }, clientes);
        }

        // DELETE api/Clientes/5
        [ResponseType(typeof(clientes))]
        public IHttpActionResult Deleteclientes(string id)
        {
            clientes clientes = db.clientes.Find(id);
            if (clientes == null)
            {
                return NotFound();
            }

            db.clientes.Remove(clientes);
            db.SaveChanges();

            return Ok(clientes);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool clientesExists(string id)
        {
            return db.clientes.Count(e => e.cedula == id) > 0;
        }
    }
}