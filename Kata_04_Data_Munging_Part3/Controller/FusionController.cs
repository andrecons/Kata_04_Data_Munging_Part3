using Kata_04_Data_Munging_Part3.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_04_Data_Munging_Part3.Controller
{
    public static class FusionController
    {
        public static void StartFootballHandler()
        {
            Console.WriteLine("*** Starting Football Part");
            FootballHandler footballHandler = new FootballHandler();
            //footballHandler.PathPrinter();
            footballHandler.Importer();
            Console.WriteLine("\nSmallest Spread:" + footballHandler.GetSmallestSpread());

            /*Printing days with smallest spread value*/
            Console.WriteLine("Registered by Team/Teams");
            string[] array = footballHandler.GetIndexSmallerSpread();

            foreach (string team in array)
            {
                Console.Write(team + " ");
            }
            Console.WriteLine("\n\n");
        }

        public static void StartWeatherHandler()
        {
            Console.WriteLine("*** Starting Weather Part");
            WeatherHandler weatherHandler = new WeatherHandler();
            //weatherHandler.PathPrinter();
            weatherHandler.Importer();
            Console.WriteLine("\nSmallest Spread:" + weatherHandler.GetSmallestSpread());
            Console.WriteLine("Registered on day/days");

            string[] daysWithLowestSpread = weatherHandler.GetIndexSmallerSpread();
            foreach (string day in daysWithLowestSpread)
            {
                Console.Write(day + " ");
            }
            Console.WriteLine("\n\n");
        }


    }
}
