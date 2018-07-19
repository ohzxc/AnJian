using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace AnJian.Models.MainFan
{
    public class Motor
    {
        static Random rd = new Random();
        public string Name { get; set; }
        [DisplayName("定子温度")]
        public double StatorTemperature { get; set; } = rd.Next(5999, 6999) * 0.01;
        [DisplayName("轴承温度")]
        public double BearingTemperature { get; set; } = rd.Next(5999, 6999) * 0.01;
        [DisplayName("垂直振动")]
        public double VerticalVibration { get; set; } = rd.Next(300, 330) * 0.01;
        [DisplayName("水平振动")]
        public double HorizontalVibration { get; set; } = rd.Next(300, 330) * 0.01;
    }
}