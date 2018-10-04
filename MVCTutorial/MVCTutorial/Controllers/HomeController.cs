using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTutorial.Models;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SideMenu()
        {
            return PartialView("SideMenu");
        }

        public JsonResult GetEmployeeRecord()
        {
            MVCTutorialEntities1 db = new MVCTutorialEntities1();
            List<EmployeeViewModel> List = db.Employees.Select(x=>new EmployeeViewModel { Name = x.Name,
                EmployeeId = x.EmployeeId,
                DepartmentId = x.DepartmentId,
                DepartmentName = x.Department.DepartmentName,
                Address = x.Addres,
                IsDeleted = x.IsDeleted }).ToList();
            return Json("", JsonRequestBehavior.AllowGet);
        }
    }
}