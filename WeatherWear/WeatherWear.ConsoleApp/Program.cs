using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherWear.ClassLib;

namespace WeatherWear.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RunThis(args).GetAwaiter().GetResult();
        }

        private static async Task RunThis(string[] args)
        {
            Console.WriteLine("Wondering what you should wear today?");
            bool correctInput = false;
            while (!correctInput)
            {
                Console.WriteLine("Please enter your 5 digit zip code");

                string zipInput = Console.ReadLine();
                if (zipInput.Length == 5)
                {
                    int zip;
                    if (int.TryParse(zipInput, out zip))
                    {
                        //If we get here, then the zip is five digits - YAY!
                        Console.WriteLine($"Yay! We got your 5 digit zip code ({zip}), now we can do something with it!");

                        //we need to switch this boolean to true so that the error message doesn't show up
                        correctInput = true;

                        //LET'S DO SOMETHING RIGHT HERE
                        WeatherUndergroundCaller wug = new WeatherUndergroundCaller();
                        string geolookupResult = await wug.CallGeoLookUp(zip);
                        Console.WriteLine(geolookupResult);

                        //now that we have the result of the first call, we can parse it and get the two digit city code and the name of the city

                        //I hard coded geneva for right now to make sure the call will work
                        string forcastResult = await wug.CallForecast("IL", "Geneva");
                        Console.WriteLine(forcastResult);

                        //when we have this result, we can parse it to get the weather details so that we can generate our clothing prediction

                        //then we send the results of the second weather call along with our prediction back to the caller
                    }
                    else
                    {
                        //couldn't parse the input
                        correctInput = false;
                    }
                }
                else
                {
                    //length was not 5
                    correctInput = false;
                }

                if (!correctInput)
                {
                    Console.WriteLine("Let's try that again.... please enter a 5 digit zip code");
                }
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}