using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace AnJian.Models.MainFan
{
    public class Fan
    { 
        static Random rd=new Random();
        public string Name { get; set; }
        [DisplayName("瓦斯浓度")]
        public double GasConcentration { get; set; } = rd.Next(39, 49)*0.01;
        [DisplayName("风流流量")]
        public double WindFlowRate { get; set; } = rd.Next(33000, 34000) * 0.01;
        [DisplayName("风机全压")]
        public double TotalPressure { get; set; } = rd.Next(4300, 4400) * 0.01;

    }
}