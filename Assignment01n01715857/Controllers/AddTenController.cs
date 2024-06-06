using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment01n01715857.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Receives an integer and returns an integer 10 more than entered integer
        /// </summary>
        /// <param name="id">the number to enter</param>
        /// <returns>
        ///  {id} +10 
        ///  </returns>
        ///  <example>
        /// GET :localhost:xx/api/AddTen/{id} -> {id} + 10
        /// GET :localhost:xx/api/AddTen/21 -> 31
        /// GET :localhost:xx/api/AddTen/0 -> 10
        /// GET :localhost:xx/api/AddTen/-9 -> 1
        /// </example>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
