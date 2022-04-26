using AutoMapper;
using Farm.Data;
using Farm.Dto;
using Farm.Models;
using Microsoft.AspNetCore.Mvc;

namespace Farm.Controllers
{
    public class PropertyController : Controller
    {
        private readonly DataContext _db;
        
        public PropertyController(DataContext db)
        {
            _db = db;
        }

        [HttpGet]
        [Route("Property")]
        public IActionResult Index ()
        {
            IEnumerable<Property> objPropertyList = _db.Properties.ToList();
            return View(objPropertyList);
        }
        
        [HttpGet]
        [Route("Property/{PropertyId}")]

       
    
        public ActionResult Details(int? PropertyId)
        {
            if (PropertyId == null)
            {
                return RedirectToAction("Index");
            }
            Property property = _db.Properties.Find(PropertyId);
            if (property == null)
            {
                return RedirectToAction("Index");
            }
            return View(property);
        }
    }
}
