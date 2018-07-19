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
            model.Name = "ͨ��� " + no + " ��������в���";
            return PartialView("MotorDetail", model);
        }
        public ActionResult FanDetail()
        {
            var model = new Fan();
            model.Name = "ͨ��� - ���в���";
            return PartialView("FanDetail", model);
        }

    }
}