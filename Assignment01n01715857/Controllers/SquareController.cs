using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment01n01715857.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Receives an integer and returns the square of the entered integer
        /// </summary>
        /// <param name="id">the number to enter</param>
        /// <returns>
        ///  {id} * {id}
        ///  </returns>
        ///  <example>
        /// GET :localhost:xx/api/Square/{id} -> {id} * {id}
        /// GET :localhost:xx/api/Square/2 -> 4
        /// GET :localhost:xx/api/Square/-2 -> 4
        /// GET :localhost:xx/api/Square/10 -> 100
        /// </example>
        public int Get(int id)
        {
            return id * id;
        }
    }
}
