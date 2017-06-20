using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace C4W.Web.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Month { get; set; }
        public int? MonthNro { get; set; }
        public string Days { get; set; }
        public int? DaysNro { get; set; }
        public string Location { get; set; }
        public string FlagUrl { get; set; }
        public string Title { get; set; }
        [AllowHtml]
        public string ShortDesc { get; set; }
        [AllowHtml]
        public string LongDesc { get; set; }
    }
}