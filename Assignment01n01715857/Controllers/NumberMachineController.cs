using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment01n01715857.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Receives an input and returns the sum, subtract, multiply and division with 10
        /// </summary>
        /// <param name="id">the input to enter</param>
        /// <returns>
        ///  "sum by 10 is ({id}+10) ,subtract by 10 is ({id}-10),multiply by 10 is ({id}*10),division by 10 is ({id}/10);
        ///  </returns>
        ///  <example>
        /// GET :localhost:xx/api/NumberMachine/{id} -> "sum by 10 is ({id}+10) ,subtract by 10 is ({id}-10),multiply by 10 is ({id}*10),division by 10 is ({id}/10
        /// GET :localhost:xx/api/NumberMachine/10 -> "sum by 10 is 20 ,subtract by 10 is 0 ,multiply by 10 is 100 ,division by 10 is 1"
        /// GET :localhost:xx/api/NumberMachine/-5 -> "sum by 10 is 5 ,subtract by 10 is -15 ,multiply by 10 is -50 ,division by 10 is 0"
        /// GET :localhost:xx/api/NumberMachine/30 -> "sum by 10 is 40 ,subtract by 10 is 20 ,multiply by 10 is 300 ,division by 10 is 3"
        /// </example>
        public string Get(int id)
        {
            int add = id + 10;
            int sub = id - 10;
            int multiply = id * 10;
            int div = id / 10;
            return "sum by 10 is " + add + " ,subtract by 10 is " + sub + " ,multiply by 10 is " + multiply + " ,division by 10 is " + div;

        }
    }
}
