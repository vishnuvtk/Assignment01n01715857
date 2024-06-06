using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment01n01715857.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Receives a message as post request and returns a string with the entered message
        /// </summary>
        /// <param></param>
        /// <returns>
        ///  "Hello World!"
        ///  </returns>
        ///  <example>
        ///  POST :localhost:xx/api/Greeting -> "Hello World!"
        /// </example>
        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// Receives an integer and returns a message with the entered integer in it.
        /// </summary>
        /// <param name="id">the integer to enter</param>
        /// <returns>
        ///  "Greetings to {id} people!"
        ///  </returns>
        ///  <example>
        /// GET :localhost:xx/api/Greeting/{id} -> "Greetings to {id} people!"
        /// GET :localhost:xx/api/Greeting/3 -> "Greetings to 3 people!"
        /// GET :localhost:xx/api/Greeting/6 -> "Greetings to 6 people!"
        /// GET :localhost:xx/api/Greeting/0 -> "Greetings to 0 people!"
        /// </example>
        public string Get(int id)
        {

            string messsage = "Greetings to " + id + " people!";
            return messsage;

        }
    }
}
