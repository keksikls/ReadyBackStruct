using Microsoft.AspNetCore.Mvc;
using MyProject.Data;
using MyProject.Models;
using System.Collections.Generic;

namespace MyProject.Controllers
{
    public class ApplicationTypeController : Controller
    {

        private readonly ApplicationDbConext _db;

        public ApplicationTypeController(ApplicationDbConext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<ApplicationType> objlist = _db.ApplicationType;
            return View(objlist);
        }

        //get - create
        public IActionResult Create()
        {
            return View();
        }
        //post - create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ApplicationType obj)
        {

            if (ModelState.IsValid)
            {
                _db.ApplicationType.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }


        //get - edit
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.ApplicationType.Find(id);

            if (id == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //post - edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ApplicationType obj)
        {

            if (ModelState.IsValid)
            {
                _db.ApplicationType.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        //get - Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.ApplicationType.Find(id);

            if (id == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //post - Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.ApplicationType.Find(id);

            if (obj == null)
            {
                return NotFound();
            }
            _db.ApplicationType.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}
