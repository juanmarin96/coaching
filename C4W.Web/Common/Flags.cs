using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace C4W.Web.Common
{
    public static class Flags
    {
        public static SelectList GetFlags()
        {
            return new SelectList(new string[] { "co", "us", "ar", "ch", "pe", "pr", "ec", "mx" }, "co");
        }
    }
}