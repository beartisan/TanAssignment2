using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TanAssignment2.Controllers
{
    public class J2ProblemController : ApiController
    {
        ///<summary>
        /// Provides the number of random combinations that two dice will the total sum of 10
        ///</summary>
        ///<param name="m">m as the first die number</param>
        ///<param name="n">n as the second die number</param>
        ///<param name="j">j as the first incrementor value</param>
        ///<param name="k">k as the second incrementor value</param>
        ///<return>
        /// Returns the number of combinations of a dice that totals to 10
        ///</return>
        /// <example>
        /// api/J2/DiceGame/{m}/{n}/} 
        /// api/J2/DiceGame/5/5
        /// "There is 1 way to get the sum of 10"
        /// </example>
        /// <example>
        /// api/J2/DiceGame/12/4
        /// "There are 4 ways to get the sum of 10"
        /// </example>
        // GET api/J2/DiceGame/{m}/{n}

        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            //assign a variable for the return statement
            int diceTen = 0;
            
            //create a loop statement for the first number
            for (int j = 0; j <= m; j++)
            {
                //nest a loop statement for the second number
                for (int i = 0; i<= n; i++)
                {

                    //if both numbers result to 10, calculate the number of combinations
                    if (j + i == 10)
                    { diceTen++; 
                    }
                 
                }
            }
            return "There is/are " + diceTen + " way/s to get the sum of 10.";            

        }
    }
}
