using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace photohub.Controllers
{
    public class bookingController : Controller
    {
        //
        // GET: /booking/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /booking/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /booking/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /booking/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /booking/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /booking/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /booking/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /booking/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
