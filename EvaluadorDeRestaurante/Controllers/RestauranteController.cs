using EvaluadorDeRestaurante.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace EvaluadorDeRestaurante.Controllers
{
    public class RestauranteController : Controller
    {
        private RestauranteDbContext _db = new RestauranteDbContext();
        // GET: Restaurante/Index
        public ActionResult Index()
        {
            return View(_db.Restaurantes.ToList());
        }

        //GET: Restaurante/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Restaurant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Restaurante restaurante)
        {
            if (ModelState.IsValid)
            {
                _db.Restaurantes.Add(restaurante);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(restaurante);
        }
        // GET: Restaurante/Delete{id}
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Restaurante restaurante = _db.Restaurantes.Find(id);
            if(restaurante == null)
            {
                return HttpNotFound();
            }
            return View(restaurante);
        }

        // POST: Restuarante/Delete/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Restaurante restaurante = _db.Restaurantes.Find(id);
            _db.Restaurantes.Remove(restaurante);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Restaurante/Edit{id}
        // Get an Id from the user
        // Handle if the Id is null
        // Find a restaurant by that id
        // If the restaurant doesn't exist
        // Return the restaurant and the view

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Restaurante restaurante = _db.Restaurantes.Find(id);
            if (restaurante == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
            return View(restaurante);
        }

        // POST: Restaurante/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Restaurante restaurante)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(restaurante).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(restaurante);
        }

        // GET:Restaurante/Details/{id}
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Restaurante restaurante = _db.Restaurantes.Find(id);
            if (restaurante == null)
            {
                return HttpNotFound();
            }
            return View(restaurante);
        }
    }
}