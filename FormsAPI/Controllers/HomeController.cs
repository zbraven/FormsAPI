using FormsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FormsAPI.Controllers
{
    public class HomeController : Controller
    {
   

        public HomeController()
        {
      
        }

        public IActionResult Index(string searchString)
        {
            var producsts = Repository.Products;
            if (!String.IsNullOrEmpty(searchString)) 
            {
                ViewBag.SearchString = searchString;    
                producsts= producsts.Where(p=>p.Name.ToLower().Contains(searchString)).ToList();  
            }
            return View(producsts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

      
    }
}