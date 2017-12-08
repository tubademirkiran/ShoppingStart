using ShoppingStart.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static ShoppingStart.BL.BusinessManager;

namespace ShoppingStart.UI.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        static CategoryModel model = new CategoryModel();
        public ActionResult StartShop()
        {
            CategoriesManager manager = new CategoriesManager();
            model.clist = manager.CategoriList();
            return View(model);
        }
        public ActionResult StartProduct(int id)
        {
            ProductsManager pm = new ProductsManager();
            model.plist = pm.Listele().Where(x => x.CategoryID == id).ToList();
            return RedirectToAction("StartShop", model);
        }
    }
}