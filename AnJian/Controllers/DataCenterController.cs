using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnJian.Controllers
{
    public class DataCenterController : Controller
    {
        // GET: DataCenter
        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// 数据交换管理-设置
        /// </summary>
        /// <returns></returns>
        public ActionResult DataExchangeSetting()
        {
            return View();
        }

    }
}