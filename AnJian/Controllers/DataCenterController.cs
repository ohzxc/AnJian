using AnJian.Models.DataCenter;
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
        public ActionResult RecordDetail(int id)
        {
            ViewBag.id = id;
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
        
        public JsonResult GetRecord(List<string> states, DateTime? startTime, DateTime? endTime)
        {
            var data = GetRecordData(states, startTime, endTime);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        private List<RecordInfo> GetRecordData(List<string> states, DateTime? startTime, DateTime? endTime)
        {
            var infos = new List<RecordInfo>();
            for (int i = 0; i < 10; i++)
            {
                infos.Add(new RecordInfo
                {
                    ID = i.ToString(),
                    State = i%2==0?RecordState.Handled:RecordState.Unhandle,
                    Origin = "sd",
                    Summary = "sdsd",
                    Category = "dsd",
                    Time=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                });
            }

            return infos;
        }

    }
}