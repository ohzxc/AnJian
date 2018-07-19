using AnJian.Models.WaterPump;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnJian.Controllers
{
    public class WaterPumpController : Controller
    {
        // GET: WaterPump
        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// 分支水泵
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public ActionResult BranchWaterPumpRunTime(string parm)
        {

            ViewBag.V = "Kv";
            ViewBag.T = " ℃";
            WatrerPumpParms wp;
            switch (parm)
            {
                case "1":
                    ViewBag.Title = "一号水泵-运行参数";
                    wp = new WatrerPumpParms();
                    ViewBag.motorVoltsge = wp.motorVoltsge;
                    ViewBag.motorTemperature = wp.motorTemperature;
                    ViewBag.frontTemperature = wp.frontTemperature;
                    ViewBag.rearTemperature = wp.rearTemperature;
                    ViewBag.statorTemperature = wp.statorTemperature;
                    break;
                case "2":
                    ViewBag.Title = "二号水泵-运行参数";
                    wp = new WatrerPumpParms();
                    ViewBag.motorVoltsge = wp.motorVoltsge;
                    ViewBag.motorTemperature = wp.motorTemperature;
                    ViewBag.frontTemperature = wp.frontTemperature;
                    ViewBag.rearTemperature = wp.rearTemperature;
                    ViewBag.statorTemperature = wp.statorTemperature;
                    break;
                case "3":
                    ViewBag.Title = "三号水泵-运行参数";
                    wp = new WatrerPumpParms();
                    ViewBag.motorVoltsge = wp.motorVoltsge;
                    ViewBag.motorTemperature = wp.motorTemperature;
                    ViewBag.frontTemperature = wp.frontTemperature;
                    ViewBag.rearTemperature = wp.rearTemperature;
                    ViewBag.statorTemperature = wp.statorTemperature;
                    break;
                default:
                    ViewBag.Title = "未知错误";
                    wp = new WatrerPumpParms();
                    ViewBag.motorVoltsge = wp.motorVoltsge;
                    ViewBag.motorTemperature = wp.motorTemperature;
                    ViewBag.frontTemperature = wp.frontTemperature;
                    ViewBag.rearTemperature = wp.rearTemperature;
                    ViewBag.statorTemperature = wp.statorTemperature;
                    break;

            }
            return View();
        }

        /// <summary>
        /// 中心水泵
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public ActionResult CenterWaterPumpRunTime()
        {
            ViewBag.H = "m";
            ViewBag.F = " m³/h";
            ViewBag.Title = "中央水泵-运行参数";
            WatrerPumpParms wp = new WatrerPumpParms();
            ViewBag.sumpLevel = wp.sumpLevel;
            ViewBag.mainFlow = wp.mainFlow;
            ViewBag.sublineFlow = wp.sublineFlow;
            return View();
        }

        /// <summary>
        /// 控制柜
        /// </summary>
        /// <returns></returns>
        public ActionResult ControlCabinetRunTime()
        {
            Random ran = new Random();
            ViewBag.Title = "控制柜-运行状态";
            //远控提示
            ViewBag.remoteControl = ran.Next(0, 2) == 0 ? true : false;
            //集控提示
            ViewBag.centralzedControl = ran.Next(0, 2) == 0 ? true : false;
            //手动提示
            ViewBag.manualControl = ran.Next(0, 2) == 0 ? true : false;
            //自动提示
            ViewBag.autoControl = ran.Next(0, 2) == 0 ? true : false;
            //主管路提示
            ViewBag.mainFlowControl = ran.Next(0, 2) == 0 ? true : false;
            //备管路提示
            ViewBag.sublineFlowControl = ran.Next(0, 2) == 0 ? true : false;
            return View();
        }

        public ActionResult Water()
        {
            //主页面
            return View();
        }


    }
}