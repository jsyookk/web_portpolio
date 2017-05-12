using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstProj_TreeView.Models;
using MyFirstProj_TreeView.DataContext;
using MyFirstProj_TreeView.ViewModel;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstProj_TreeView.Controllers
{
    public class AccountController : Controller
    {
        private readonly DatabaseContext _db;

        public AccountController(DatabaseContext db)
        {
            _db = db;
                
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserView model)
        {
            if (ModelState.IsValid)
            {

                   var user = _db.Users.FirstOrDefault(u => u.UserId.Equals(model.UserId)
                                && u.UserPassword.Equals(model.UserPassword));
                    if (user != null)
                    {
                        HttpContext.Session.SetInt32("USER_KEY", user.UserNo);
                        return RedirectToAction("Index", "Home");
                    }

               

                ModelState.AddModelError(String.Empty, "사용자 ID 나 PASSWORD가 잘못되었습니다");


            }

            return View(model);

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("USER_KEY");
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {

                model.RegDate = DateTime.Now;

             
                    _db.Users.Add(model);
                    _db.SaveChanges();

                

                return RedirectToAction("Index", "Home");

            }
            
            return View();

        }




    }
}
