using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingStart.UI
{
    public class AuthorizationAdmin : ActionFilterAttribute, IAuthorizationFilter
    {

        //Burası web admin girişinde login e yönlendirir
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (HttpContext.Current.Session["Role"].ToString() != "ADMIN")
            {
                HttpContext.Current.Session["ErrorMsg"] = "Bu sayfaya giriş yetkiniz bulunmamaktadır.Devam edebilmek için lütfen giriş yapınız.";
                filterContext.Result = new RedirectResult("/Login/Hata");
            }
        }
    }
}