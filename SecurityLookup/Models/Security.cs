using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecurityLookup.Models
{
    public class Security
    {
        public int SecurityId { get; set; }
        public string SecurityCode { get; set; }
        public string SecurityName { get; set; }
        public string SEDOL { get; set; }
        public string CUSIP { get; set; }
        public string ISIN { get; set; }
    }
}