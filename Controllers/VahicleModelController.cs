using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MonoProjekt.MVC.Controllers
{
    public class VahicleModelController : Controller
    {
        // GET: VahicleModelController
        public ActionResult Index()
        {
            return View();
        }

        // GET: VahicleModelController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VahicleModelController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VahicleModelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VahicleModelController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VahicleModelController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VahicleModelController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VahicleModelController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
