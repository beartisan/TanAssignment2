using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;

namespace TanAssignment2.Controllers
{
    public class J3ProblemController : ApiController
    {
        ///<summary>
        /// Calculates the distance between any two cities. Also provides total number of distance from origin to the current city, and the total number of distances to the preceeding destinations.
        ///</summary>
        ///<return>
        /// Returns 5 line statements indicating cities distance to each other.
        ///</return>
        ///<param name="cities">Assigned array for city</param>
        ///<param name="distances">Assigned array for the distance</param>
        ///<param name="i"> assigned incrementor for city</param>
        ///<param name="j"> assigned incrementor to calculate the distance from the starting point (west)</param>
        ///<example>
        /// GET/api/J3/DistanceCalculator/{distance1}/{distance2}/{distance3}/{distance4} 
        /// api/J3/DistanceCalculator/3/10/12/5 
        /// Output:
        /// First Line: 0/3/13/25/30 -> 0 is the distance of the current destination
        /// Second Line: 3/0/10/22/27
        /// Third Line: 13/10/0/12/17
        /// Fourth Line: 25/22/12/0/5
        /// Fifth Line: 30/27/17/5/0
        /// </example>

        // GET api/J3/DistanceCalculator/{distance1}/{distance2}/{distance3}/{distance4}/
        [HttpGet]
        [Route("api/J3/DistanceCalculator/{distance1}/{distance2}/{distance3}/{distance4}")]
        
        public int DistanceCalculator(int distance1, int distance2, int distance3, int distance4)
        {
            //declare variables and array
            List <int> cities = new List<int> {5};
            List <int> distances = new List<int> {4};
            int currentDistance = 0;

            //loop representing 5 different starting points of 5 cities
            for (int i = 0; i < 5; i++)
            {

                

                //write distance[i]
                //Console.WriteLine("You are starting in city: " + i);

                //start at 0 since city 1 is starting point
                int cities[0] =  0;
                //continue adding distance per number given
                int cities[i] = cities[i - 1] + distances[i-1];
                 
                return cities[i+1] + " " + cities[i+2] + " " + cities[i+3] + " " + cities[i+4] + " " + cities[i+5]; 

                //Console.WriteLine("East-------------");
                //Console.WriteLine("You are starting in city: " + i + " and driving to city 0");distances[

                int distances[i] = cities[i + 1] - cities[i]; 


                //create a loop calculating the distance of the city from the original destination
                for (int j = i; j >= 0; j--)
                {
                    int formerDistance = cities[j] - cities[j - 1];
                    //Console.WriteLine("The distance from previous city is " + j);

                    //convert negative numbers into positive
                    if (formerDistance < 0)
                    {
                        formerDistance *= -1;
                    }
                    else
                    {
                        formerDistance *= 1;
                    }

                    //print
                    return formerDistance;
                }


                //show former distance 
                return formerDistances;

                //Console.WriteLine("West--------------");
                //Console.WriteLine("You are started in city: " + i + " and driving to city 4");

                //calculates the city from the starting point
                for (int j = i; j < 5; j++)
                {
                    distances[j + 1] = distances[j] + distances[j + 1];

                    int city5 = 0;
                    int city4 = distances[j-1] - city5;
                    int city3 = distances[j - 1] - city4;
                    int city2 = distances[j - 1] - city5;
                    int city1 = distances[j - 1] - city2;

                    //Console.WriteLine("The distance from previous city is " + i);
                    
                    //Console.WriteLine("You are starting in city: " + j);

                }


            }
            currentDistance = distance1 + distance2 + distance3 + distance4;

            //return the distance
            return currentDistance;
        }
    } 
    
}
