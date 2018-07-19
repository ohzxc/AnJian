using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models.MainFan;

namespace WebApplication2.Controllers
{
    public class MainFanController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        

        public ActionResult MotorDetail(string no)
        {
            var model = new Motor();
            model.Name = "通风机 " + no + " 级电机运行参数";
            return PartialView("MotorDetail", model);
        }
        public ActionResult FanDetail()
        {
            var model = new Fan();
            model.Name = "通风机 - 运行参数";
            return PartialView("FanDetail", model);
        }

    }
}