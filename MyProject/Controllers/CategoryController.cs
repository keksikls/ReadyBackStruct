using Microsoft.AspNetCore.Mvc;
using MyProject.Data;
using MyProject.Models;
using System.Collections.Generic;

namespace MyProject.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDbConext _db;

        public CategoryController(ApplicationDbConext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objlist = _db.Category;
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
        public IActionResult Create(Category obj)
        {

            if (ModelState.IsValid)
            {
                _db.Category.Add(obj);
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

            var obj = _db.Category.Find(id);

            if (id == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //post - edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category obj)
        {

            if (ModelState.IsValid)
            {
                _db.Category.Update(obj);
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

            var obj = _db.Category.Find(id);

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
            var obj = _db.Category.Find(id);

            if (obj == null)
            {
                return NotFound();
            }
            _db.Category.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}
