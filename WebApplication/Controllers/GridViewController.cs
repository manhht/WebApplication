using WebApplication.Model;
using System;
using System.Web.Mvc;
using WebApplication.Code;
using MimeKit;

namespace WebApplication.Controllers {
    public class GridViewController : Controller {
        // GET: GridView
        public ActionResult Index()
        {
            return View(GridViewHelper.GetIssues());
        }
        public ActionResult GridViewDetailsPage(long id) {
            ViewBag.ShowBackButton = true;
            return View(DataProvider.GetIssues().Find(i => i.Id == id));
        }
        public ActionResult GridViewPartial() {
            return PartialView("GridViewPartial", GridViewHelper.GetIssues());
        }
        [ValidateAntiForgeryToken]
        public ActionResult GridViewCustomActionPartial(string customAction) {
          
            return GridViewPartial();
        }
        [ValidateAntiForgeryToken]
        public ActionResult GridViewAddNewPartial(Issue issue) {
            return UpdateModelWithDataValidation(issue, GridViewHelper.AddNewRecord);
        }
        [ValidateAntiForgeryToken]
        public ActionResult GridViewUpdatePartial(Issue issue) {
            return UpdateModelWithDataValidation(issue, GridViewHelper.UpdateRecord);
        }

        private ActionResult UpdateModelWithDataValidation(Issue issue, Action<Issue> updateMethod) {

            return GridViewPartial();
        }
        private void PerformDelete() {
            if(!string.IsNullOrEmpty(Request.Params["SelectedRows"]))
                GridViewHelper.DeleteRecords(Request.Params["SelectedRows"]);
        }
    }
}