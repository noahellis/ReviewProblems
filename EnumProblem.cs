using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    class EnumProblem
    {
        public enum Days
        {
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
            Monday,
            Tuesday
        };

        public enum Weather
        {
            Sunny,
            Rainy,
            Snowy,
            Cloudy,
            Cold,
            Warm 
        };      
        public void PrintWeather()
        {
            Random weatherRandom = new Random();
            Days days = Days.Wednesday | Days.Thursday | Days.Friday | Days.Saturday | Days.Sunday | Days.Monday | Days.Tuesday;
            Weather dailyweather = Weather.Sunny | Weather.Rainy | Weather.Snowy | Weather.Cloudy | Weather.Cold | Weather.Warm;
            for (int dayWeather = 0; dayWeather <(Enum.GetNames(typeof(Days)).Length); dayWeather ++)
            {

                int determineWeather = weatherRandom.Next(0, 6);
                {
                    Console.WriteLine("The weather on {0} will be {1}.", Enum.GetName(typeof(Days), dayWeather),  Enum.GetName(typeof(Weather), determineWeather));
                }

            }
            
        }
       
    }
}