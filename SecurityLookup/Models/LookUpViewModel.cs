using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace SecurityLookup.Models
{
    public class LookUpViewModel
    {
        [Display(Name = "Security Code")]
        public string SecurityCode { get; set; }

        [Display(Name = "Search for Text")]
        public string SearchText { get; set; }
    }
}