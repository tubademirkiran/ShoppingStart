using ShoppingStart.BL;
using ShoppingStart.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static ShoppingStart.BL.BusinessManager;

namespace ShoppingStart.UI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            UsersManager manager = new UsersManager();
            UserDto UserDto = manager.Denetle(model.user.UserID, model.user.Password);
            Session["User"] = UserDto.UserId;
            Session["Role"] = UserDto.Role;
            if (Session["Role"].ToString() == "ADMIN")
            {
                return RedirectToAction("Admin", "Admin");
            }
            else
            {
                return RedirectToAction("Index", "Home");//önce view sonra controller
            }

        }
        public ActionResult Hata()
        {
            return View();
        }
        public ActionResult LogOut()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
