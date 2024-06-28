using InventoryManagementMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryManagementMVC.Controllers.Auth
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            ViewBag.Message = "";
            return View();
        }

        // Post: User Login
        [HttpPost]
        public ActionResult Login(User _model)
        {
            if (_model.UserName == "Admin" && _model.Password == "123")
            {
                Session["User"] = _model.UserName;
                ViewBag.Message = "User Login Success";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "User Login Failed";
                return View();
            }
        }
    }
}