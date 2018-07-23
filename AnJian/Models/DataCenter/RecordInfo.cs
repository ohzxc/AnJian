using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnJian.Models.DataCenter
{
    public class RecordInfo
    {
        public string ID { get; set; }
        public string Category { get; set; }
        public string Summary { get; set; }
        public string Origin { get; set; }
        public RecordState State { get; set; }


    }
}