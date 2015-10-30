using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SecurityLookup.Models;

namespace SecurityLookup.Repository
{
    internal class SecRepository
    {
        private static readonly List<Security> securities = new List<Security>
            { 
               new Security{SecurityId =1, SecurityCode="YHOO", SecurityName = "Yahoo", SEDOL="1111234", CUSIP="459200-10-1", ISIN="123123456123" },
               new Security{SecurityId =2, SecurityCode="MSFT", SecurityName = "Microsoft", SEDOL="2224567", CUSIP="459198-10-1" },
               new Security{SecurityId =3, SecurityCode="AAPL", SecurityName = "Apple", SEDOL="3337890", CUSIP="459184-10-1", ISIN="123456123789" },
               new Security{SecurityId =4, SecurityCode="GOOG", SecurityName = "Alphabet", SEDOL="4446756", CUSIP="459555-10-1" },
            };

        internal SecRepository() { }

        internal List<Security> SecuritySearchLookup(string SecurityCode, string SearchText)
        {
            List<Security> secReturnList = new List<Security>();
            List<Security> securitiesFound = null;

            

            Security securityFound = securities.Find(s => s.SecurityCode == SecurityCode.ToUpper());
            
            if (!string.IsNullOrEmpty(SearchText))
            {
                securitiesFound = securities.FindAll(s => s.SecurityName.ToUpper().Contains(SearchText.ToUpper()));
            }
            
            if (securityFound != null)
            {
                secReturnList.Add(securityFound);
            }

            if (securitiesFound != null)
            {
                foreach(Security security in securitiesFound)
                {
                    secReturnList.Add(security);
                }
            }
            return secReturnList;
        }

    }
}