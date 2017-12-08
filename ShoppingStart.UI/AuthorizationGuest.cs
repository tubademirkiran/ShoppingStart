using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingStart.UI
{
    public class AuthorizationGuest : ActionFilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (HttpContext.Current.Session["Role"] == null)
            {
                HttpContext.Current.Session["Role"] = "Guest";
            }



        }

    }
}