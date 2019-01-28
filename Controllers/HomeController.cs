using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaiYAMain.Models;
using SaiYAMain.ViewModel;
using SaiYAMain.auth;

namespace SaiYAMain.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Login(){
            return View();
        }

        public IActionResult Teachings()
        {
            return View();
        }

        public IActionResult Service()
        {
            return View();
        }

        public IActionResult Ceiling()
        {
            return View();
        }

        public IActionResult GoGreen()
        {
            return View();
        }

        public IActionResult getInExisting([FromBody] ExistingUser existingUser ){
            SaiHashing sai = new SaiHashing();
            existingUser.epd  = sai.Hashing(existingUser.epd);
            var result = new { success = true, user = existingUser };
            return Json(result);
        }

        public IActionResult getInNew([FromBody] NewUser newUser ){
            SaiHashing sai = new SaiHashing();
            newUser.pd  = sai.Hashing(newUser.pd);
            var result = new { success = true, user = newUser };
            return Json(result);
        }


    }
}
