using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using crudoperation_MVC.Models;

namespace crudoperation_MVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            using (testEntities testentities = new testEntities())
            {
                return View(testentities.customers.ToList());
            }
               
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            using (testEntities testentities = new testEntities())
            {
                return View(testentities.customers.Where(x=> x.CustomerId==id).FirstOrDefault());
            }
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(customer customer)
        {
            try
            {
                // TODO: Add insert logic here
                using (testEntities testentities =new testEntities())
                {
                    testentities.customers.Add(customer);
                    testentities.SaveChanges();
                }
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            using (testEntities testentities = new testEntities())
            {
                return View(testentities.customers.Where(x => x.CustomerId == id).FirstOrDefault());
            }
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id , customer customer)
        {
            try
            {
                // TODO: Add update logic here

                using (testEntities testentities = new testEntities())
                {
                    testentities.Entry(customer).State = System.Data.Entity.EntityState.Modified;
                    testentities.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int? id)
        {
            using (testEntities testentities = new testEntities())
            {
                return View(testentities.customers.Where(x => x.CustomerId == id).FirstOrDefault());
            }
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (testEntities testentities = new testEntities())
                {
                    customer customer = testentities.customers.Where(x => x.CustomerId == id).FirstOrDefault();
                    testentities.customers.Remove(customer);
                    testentities.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
