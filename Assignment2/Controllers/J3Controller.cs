using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{

    public class J3Controller : ApiController
    {
        /// <summary>
        /// 2021 J3 Problem : SecretInstructions
        /// take two numbers integer where first num is of 2 digit and second one is of 3 digits
        /// Each instruction is a sequence of five digits which represents a direction to turn and the number of steps to take. 
        /// The first two digits represent the direction to turn: 
        /// •If their sum is odd,then the direction to turn is left. 
        /// •If their sum is even and not zero,then the direction to turn is right. 
        /// •If their sum is zero,then thedirection to turn is the same as the previous instruction.   ***(not implemented as working for one input at a time only.)
        /// /// </summary>
        /// <param name="direction">Use to set direction</param>
        /// <param name="steps">use for  steps </param>
        /// <returns> return directions and steps</returns>
        /// <example>
        ///     GET : /api/J3/SecretInstruction/57/234      ->      Right 234
        /// </example>

        [HttpGet]
        [Route("api/J3/SecretInstruction/{direction}/{steps}")]
        public string Calculate(int direction, int steps)
        {
            string data = "";
            string directionData = direction.ToString();
            string stepsData = steps.ToString();
            if (directionData.Length == 2 && stepsData.Length == 3 )
            {
                int sum = 0;
                while (direction > 0)
                {
                    sum = sum + direction % 10;
                    direction = direction / 10;
                }
               
                if (sum % 2 == 0 && sum != 0)
                {
                    data = "Right " + steps;
                }
                else if (sum % 2 == 1)
                {
                    data = "left " + steps;
                }
                else if(sum == 0)
                {
                    data = "No Cordinates found";
                }
            }
            else {
                data = "Invalid input.";
            }
            return  data;
        }

    }
}
