using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnJian.Models.MainFan
{
    public class MainFan
    {

        public Fan Fan1_1 { get; set; } = new Fan();
        public Fan Fan1_2 { get; set; } = new Fan();
        public Fan Fan2_1 { get; set; } = new Fan();
        public Fan Fan2_2 { get; set; } = new Fan();
        public Motor Motor1 { get; set; } = new Motor();
    }
}