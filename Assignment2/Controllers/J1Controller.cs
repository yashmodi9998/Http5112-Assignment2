using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
    {

        /// <summary>
        /// Assignment problem
        /// takes four numbers and count calories.
        /// </summary>
        /// <param name="burger">The first number to add</param>
        /// <param name="drink">The second number to add</param>
        /// <param name="side">The third number to add</param>
        /// <param name="dessert">The third number to add</param>
        /// <returns>The four numbers takes value from array and calculate callories </returns>
        /// <example>
        ///     GET : /api/J1/Menu/1/2/3/4      ->      Your total calorie count is 691
        /// </example>

        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Calculate ( int burger, int drink, int side, int dessert)
        {
            int[] burgerData = { 461, 431, 420, 0 };
            int[] drinkData = { 130, 160, 118, 0 };
            int[] sideData = { 100, 57, 70, 0 };
            int[] dessertData = { 167, 266, 75, 0 };

            if (burger < 1 || burger > 4 || drink < 1 || drink > 4 || side < 1 || side > 4 || dessert < 1 || dessert > 4)
            {
                return "Please select between 1 to 4";
            }

            int totalData = burgerData[burger - 1] + drinkData[drink - 1] + sideData[side - 1] + dessertData[dessert - 1] ;
            return "Your total calorie count is " +totalData;
        }
    }
}
