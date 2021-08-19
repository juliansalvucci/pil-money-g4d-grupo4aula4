using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Monar.Controllers
{
    public class TarjetaController : Controller
    {
        // GET: Tarjeta
        public ActionResult Index()
        {
            return View();
        }

        // GET: Tarjeta/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tarjeta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tarjeta/Create
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

        // GET: Tarjeta/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tarjeta/Edit/5
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

        // GET: Tarjeta/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tarjeta/Delete/5
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
