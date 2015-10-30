using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SecurityLookup.Models;
using SecurityLookup.Repository;

namespace SecurityLookup.Controllers
{
    public class SecurityLookUpController : Controller
    {
        private SecRepository repository;

        //dependence injection omitted
        public SecurityLookUpController()
        {
            repository = new SecRepository();
        }


        // GET: SecurityLookUp
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [OutputCache(Duration=0, NoStore=true)]
        public PartialViewResult Search(string SecurityCode, string SearchText)
        {
            List<Security> securities = repository.SecuritySearchLookup(SecurityCode, SearchText);
            SearchResultViewModel srvm = new SearchResultViewModel { Securities = securities };
            return PartialView("_SearchResultPartialView", srvm);
        }
    }
}