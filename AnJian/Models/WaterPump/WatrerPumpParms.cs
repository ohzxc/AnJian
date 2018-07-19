using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace AnJian.Models.WaterPump
{
    public class WatrerPumpParms
    {
        static Random ran = new Random();

        [DisplayName("水仓液位")]
        public string sumpLevel { get; set; } = (ran.Next(300, 400) * 0.01).ToString(".00");
        [DisplayName("主管路流量")]
        public string mainFlow { get; set; } = (ran.Next(20000, 40000) * 0.01).ToString(".00");
        [DisplayName("备用管路流量")]
        public string sublineFlow { get; set; } = (ran.Next(20000, 40000) * 0.01).ToString(".00");
        [DisplayName("电机电压")]
        public string motorVoltsge { get; set; } = (ran.Next(300, 500) * 0.01).ToString(".00");
        [DisplayName("电机温度")]
        public string motorTemperature { get; set; } = (ran.Next(5000, 7000) * 0.01).ToString(".00");
        [DisplayName("前轴温度")]
        public string frontTemperature { get; set; } = (ran.Next(5000, 7000) * 0.01).ToString(".00");
        [DisplayName("后轴温度")]
        public string rearTemperature { get; set; } = (ran.Next(5000, 7000) * 0.01).ToString(".00");
        [DisplayName("定子温度")]
        public string statorTemperature { get; set; } = (ran.Next(5000, 7000) * 0.01).ToString(".00");
    }
}