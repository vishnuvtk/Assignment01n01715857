using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment01n01715857.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// Receives an integer and returns a message with calculation
        /// </summary>
        /// <param name="id">the integer to enter</param>
        /// <returns>
        /// fortnights + " fortnights at $5.50/FN = $" + charge + " CAD, " +
        /// "HST 13 % =$" + HST13 + " CAD, " + 
        /// "Total = $" + total + " CAD";
        /// </returns>
        /// <example>
        /// GET :localhost:xx/api/HostingCost/{id} -> fortnights + " fortnights at $5.50/FN = $" + charge + " CAD, " + "HST 13 % =$" + HST13 + " CAD, " + "Total = $" + total + " CAD";
        /// GET :localhost:xx/api/HostingCost/0 -> “1 fortnights at $5.50/FN = $5.50 CAD” “HST 13% = $0.72 CAD”“Total = $6.22 CAD”
        /// GET :localhost:xx/api/HostingCost/14 -> “2 fortnights at $5.50/FN = $11.00 CAD”“HST 13% = $1.43 CAD”“Total = $12.43 CAD”
        /// GET :localhost:xx/api/HostingCost/15 -> “2 fortnights at $5.50/FN = $11.00 CAD”“HST 13% = $1.43 CAD”“Total = $12.43 CAD”
        /// GET :localhost:xx/api/HostingCost/21 -> “2 fortnights at $5.50/FN = $11.00 CAD”“HST 13% = $1.43 CAD”“Total = $12.43 CAD”
        /// GET :localhost:xx/api/HostingCost/28 -> “3 fortnights at $5.50/FN = $16.50 CAD”“HST 13% = $2.14 CAD”“Total = $18.64 CAD”
        /// </example>
        public string Get(int id)
        {
            int fortnights = (id / 14) + 1;
            double charge = Math.Round((fortnights * 5.50), 2);
            double HST13 = Math.Round((charge * 13 / 100), 2);
            double total = Math.Round((charge + HST13), 2);

            return fortnights + " fortnights at $5.50/FN = $" + charge + " CAD, " +
            "HST 13 % =$" + HST13 + " CAD, " +
            "Total = $" + total + " CAD";


        }
    }
}
