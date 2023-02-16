using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Model;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(HomeController));
        public ActionResult Index()
        {
            return View(DataProvider.GetIssues().ToList());
        }
        public ViewResult GenericError(HandleErrorInfo exception)
        {
            ViewBag.Title = exception?.Exception?.Message;
            try
            {
                Log.Error("ControllerName: "+ exception?.ControllerName+ ". - ActionName: " + exception?.ActionName + ". - Message: " +exception?.Exception?.Message+ " - StackTrace: " + exception?.Exception?.StackTrace);
                return View("Error", exception);
            }
            catch (Exception ex)
            {
                Log.Error("ControllerName: " + exception?.ControllerName + ". - ActionName: " + exception?.ActionName + ". - Message: " + exception?.Exception?.Message + " - StackTrace: " + exception?.Exception?.StackTrace + ". EX: "+ ex.Message);
                return View("Error", exception);
            }

        }

        public ViewResult NotFound(HandleErrorInfo exception)
        {
            ViewBag.Title = exception?.Exception?.Message;
            try
            {
                Log.Error("ControllerName: " + exception?.ControllerName + ". - ActionName: " + exception?.ActionName + ". - Message: " + exception?.Exception?.Message + " - StackTrace: " + exception?.Exception?.StackTrace);
                return View("Error", exception);
            }
            catch (Exception ex)
            {
                Log.Error("ControllerName: " + exception?.ControllerName + ". - ActionName: " + exception?.ActionName + ". - Message: " + exception?.Exception?.Message + " - StackTrace: " + exception?.Exception?.StackTrace + ". EX: " + ex.Message);
                return View("Error", exception);
            }
        }
    }
}