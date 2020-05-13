using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThuVien.Controllers
{
    public class BaseController : Controller
    {
        //protected override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    var session = (UserLogin)Session[CommonConstant.USER_SESSION];
        //    if (session == null)
        //    {
        //        // nếu không có Session thì chuyển về trang Login
        //        filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Login", action = "Index", Area = "Admin" }));
        //    }
        //    base.OnActionExecuting(filterContext);
        //}

        //Set thông báo alert boostrap
        protected void SetAlert(string message, string type)
        {
            TempData["AlertMessage"] = message;
            if (type == "susscess")
            {
                TempData["AlertType"] = "alert-success";
            }
            else if (type == "warning")
            {
                TempData["AlertType"] = "alert-warning";
            }
            else if (type == "erro")
            {
                TempData["AlertType"] = "alert-danger";
            }
        }
    }
}