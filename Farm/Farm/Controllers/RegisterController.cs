using Farm.Data;
using Farm.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Farm.Controllers
{
    public class RegisterController : Controller
    {
        private readonly DataContext _db;

        public RegisterController(DataContext db)
        {
            _db = db;

        }
        /*
        [Authorize(Roles= "admin")]
        [Route("registeredlist")]
        [HttpGet]
        */
        public IActionResult RegisteredList()
        {
            IEnumerable<Register> objRegisterList = _db.Registers.ToList();
            return View(objRegisterList);
        }

        public IActionResult Create()
        {
            return View();
        }

        //POST
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public IActionResult Create(Register obj)
        {
            
                _db.Registers.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("RegisteredList");
          
            
            //return View(obj);
        }


    }
}
