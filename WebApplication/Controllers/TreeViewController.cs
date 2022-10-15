using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Model;

namespace WebApplication.Controllers
{
    public class TreeViewController : Controller
    {
        // GET: TreeView
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GridViewPartial()
        {

            List<TreeListModel> list = new List<TreeListModel>();
            list.Add(new TreeListModel { Id=1,Name="1",IdParent=null});  
            list.Add(new TreeListModel { Id=2,Name="2",IdParent=1});  
            list.Add(new TreeListModel { Id=3,Name="3",IdParent=2});  
            list.Add(new TreeListModel { Id=4,Name="4",IdParent=3});  
            list.Add(new TreeListModel { Id=5,Name="5",IdParent=4});  
            list.Add(new TreeListModel { Id=6,Name="6",IdParent=null});  
            list.Add(new TreeListModel { Id=7,Name="7",IdParent=6});  
            list.Add(new TreeListModel { Id=8,Name="8",IdParent=7});  
            list.Add(new TreeListModel { Id=9,Name="9",IdParent=8});  
            return PartialView("GridViewPartial", list.ToList());
        }
    }
}