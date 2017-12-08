using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingStart.UI
{
    
        public class AuthorizationUser : ActionFilterAttribute, IAuthorizationFilter
        {

            //Burası kullanıcı girişi yapmayanların ödeme ve sipariş takibine girişini engeller
            public void OnAuthorization(AuthorizationContext filterContext)
            {
                if (HttpContext.Current.Session["User"] == null)
                {
                    HttpContext.Current.Session["ErrorMsg"] = "Bu sayfaya giriş yetkiniz bulunmamaktadır.Devam edebilmek için lütfen giriş yapınız.";
                    filterContext.Result = new RedirectResult("/Login/Hata");
                }
            }
        }
}