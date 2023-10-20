using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J2Controller : ApiController
    {

        /// <summary>
        /// Assignment problem
        /// take two numbers of dice and applies logic for how many time total of 2 dice is 10
        /// </summary>
        /// <param name="dice1">The first number to add</param>
        /// <param name="dice2">The second number to add</param>
        /// <returns>The two numbers takes value of dice and return how many times total is equals to 10.</returns>
        /// <example>
        ///     GET : /api/J2/DiceGame/12/4      ->      There are 4 total ways to get the sum 10.
        /// </example>
        [HttpGet]
        [Route("api/J2/DiceGame/{dice1}/{dice2}")]
        public string Calculate(int dice1, int dice2) {

            
            int counter = 0;
            for(int i = 1;i<= dice1;i++)
            {
                for(int j = 1; j <= dice2; j++)
                {
                    
                    if (i+j == 10) 
                    { 
                        counter++;
                    }
                }
            }
            return "There are " + counter+" total ways to get the sum 10.";
        }
    }
}
