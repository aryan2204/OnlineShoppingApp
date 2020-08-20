﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using OnlineShopping.Models;

namespace OnlineShopping.Controllers
{
    public class PwdResetController : ApiController
    {
        private Online_ShoppingEntities db = new Online_ShoppingEntities();

        // GET: api/PwdReset
        public IQueryable<Customer> GetCustomers()
        {
            return db.Customers;
        }

        // GET: api/PwdReset/5
        [ResponseType(typeof(Customer))]
        public IHttpActionResult GetCustomer(int id)
        {
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        // PUT: api/PwdReset/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCustomer(int id, Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != customer.Id)
            {
                return BadRequest();
            }

            db.Entry(customer).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(id))
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

        // POST: api/PwdReset
        [ResponseType(typeof(Customer))]
        public IHttpActionResult PostCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            int myUser = db.Customers.Where(u => u.Customer_EMail == customer.Customer_EMail).Count();
            Customer tbl_User2 = db.Customers.ToList().Find(u => u.Customer_EMail == customer.Customer_EMail);

            if (myUser == 1)
            {
                db.UpdateCustomerPassword(customer.Password, customer.Customer_EMail);
                db.SaveChanges();
                //tbl_User tbl_User1 = db.tbl_User.Find(email);
                return Ok(tbl_User2.Id);

            }
            else
            {
                return BadRequest();
            }

            //db.Customers.Add(customer);
            //

            //return CreatedAtRoute("DefaultApi", new { id = customer.Id }, customer);
        }

        // DELETE: api/PwdReset/5
        [ResponseType(typeof(Customer))]
        public IHttpActionResult DeleteCustomer(int id)
        {
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return NotFound();
            }

            db.Customers.Remove(customer);
            db.SaveChanges();

            return Ok(customer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CustomerExists(int id)
        {
            return db.Customers.Count(e => e.Id == id) > 0;
        }
    }
}