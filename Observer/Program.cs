using Observer.Observers;
using Observer.Subjects;
using System;
using System.Threading;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            var currentCondition = new CurrentConditionDisplay(weatherData);
            var avgCondition = new AveragesConditionDisplay(weatherData);

            PrintGlobalMessage();
            weatherData.SetMeasurements(80, 65, 30.4f);
            Thread.Sleep(500);

            PrintGlobalMessage();
            weatherData.SetMeasurements(82, 70, 29.2f);
            Thread.Sleep(500);

            PrintGlobalMessage();
            weatherData.SetMeasurements(78, 90, 29.2f);
            Thread.Sleep(500);

            Console.ReadKey();
        }

        private static void PrintGlobalMessage()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nПришли новые данные");
        }
    }
}
