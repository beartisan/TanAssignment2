using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TanAssignment2.Controllers
{
    public class J1ProblemController : ApiController
    {
        ///<summary>
        ///Calculates the total calorie count of the user's meal
        ///</summary>
        ///<return>
        ///Returns the total calories of the items ordered
        ///</return>
        ///<param name="burger">The integer representing the calorie count of the first number burger</param>
        ///<param name="drink">The integer representing the calorie count of the second number drink</param>
        ///<param name="side">The integer representing the calorie count of the third number side</param>
        ///<param name="dessert">The integer representing the calorie count of the fourt number dessert</param>
        ///<example>
        /// api/J1/Menu/{burger}/{drink}/{side}/{dessert} --> api/J1/Menu/1/2/3/4
        /// "Your total calorie count is 691"
        /// </example>
        /// <example>
        /// api/J1/Menu/{burger}/{drink}/{side}/{dessert} --> api/J1/Menu/4/4/4/4
        /// "Your total calorie count is 0"
        /// </example>

        // GET api/J1/Menu/{burger}/{drink}/{side}/{dessert}
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        
        public string GetMenu(int burger, int drink, int side, int dessert)
        {
            //assign a variable for the total number of calories
            int totalCalories = 0;
           
            //create logic: if statement to count total number of calories for int burger
            if (burger == 1 )
            {
                totalCalories += 461; 
            } 
            else if (burger == 2)
            {
                totalCalories += 431;
            }
            else if (burger == 3)
            {
                totalCalories += 420;
            }


            //create logic: if statement to count total number of calories for int drink
            if (drink == 1)
            {
                totalCalories += 130;
            }
            else if (drink == 2)
            {
                totalCalories += 160;
            }
            else if (drink == 3)
            {
                totalCalories += 118;
            }


            //create logic: if statement to count total number of calories for int side
            if (side == 1)
            {
                totalCalories += 100;
            }
            else if (side == 2)
            {
                totalCalories += 57;
            }
            else if (side == 3)
            {
                totalCalories += 70;
            }


            //create logic: if statement to count total number of calories for int dessert
            if (dessert == 1)
            {
                totalCalories += 167;
            }
            else if (dessert == 2)
            {
                totalCalories += 266;
            }
            else if (dessert == 3)
            {
                totalCalories += 75;
            }

           //returns the total calorie count
            return "Your calorie count is " + totalCalories;
        }


    }
}