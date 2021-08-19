using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Monar.Controllers
{
    public class TipoMonedaController : Controller
    {
        // GET: TipoMoneda
        public ActionResult Index()
        {
            return View();
        }

        // GET: TipoMoneda/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TipoMoneda/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoMoneda/Create
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

        // GET: TipoMoneda/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoMoneda/Edit/5
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

        // GET: TipoMoneda/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoMoneda/Delete/5
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
