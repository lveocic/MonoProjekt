using Microsoft.AspNetCore.Mvc;
using MonoProjekt.Models;
using System.Diagnostics;

namespace MonoProjekt.Controllers
{
    public class VehicleMakeController : Controller
    {
        #region Constructors

        public VehicleMakeController()
        {
        }

        #endregion Constructors

        #region Methods

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        #endregion Methods
    }
}