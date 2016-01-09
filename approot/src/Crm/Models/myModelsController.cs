using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Crm.Models;

namespace Crm.Controllers
{
    public class myModelsController : Controller
    {
        private ApplicationDbContext _context;

        public myModelsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: myModels
        public IActionResult Index()
        {
            return View(_context.myModel.ToList());
        }

        // GET: myModels/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            myModel myModel = _context.myModel.Single(m => m.myModelID == id);
            if (myModel == null)
            {
                return HttpNotFound();
            }

            return View(myModel);
        }

        // GET: myModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: myModels/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(myModel myModel)
        {
            if (ModelState.IsValid)
            {
                _context.myModel.Add(myModel);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(myModel);
        }

        // GET: myModels/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            myModel myModel = _context.myModel.Single(m => m.myModelID == id);
            if (myModel == null)
            {
                return HttpNotFound();
            }
            return View(myModel);
        }

        // POST: myModels/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(myModel myModel)
        {
            if (ModelState.IsValid)
            {
                _context.Update(myModel);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(myModel);
        }

        // GET: myModels/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            myModel myModel = _context.myModel.Single(m => m.myModelID == id);
            if (myModel == null)
            {
                return HttpNotFound();
            }

            return View(myModel);
        }

        // POST: myModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            myModel myModel = _context.myModel.Single(m => m.myModelID == id);
            _context.myModel.Remove(myModel);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
