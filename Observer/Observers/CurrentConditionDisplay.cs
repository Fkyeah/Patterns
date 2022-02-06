using Observer.Interfaces;
using System;

namespace Observer.Observers
{
    public class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        public CurrentConditionDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        private float _temperature;
        private float _humidity;
        private ISubject _weatherData;

        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCurrentConditionDisplay:");
            var message = string.Format("Current conditions: {0}F degrees and {1}% humidity", _temperature, _humidity);
            Console.WriteLine(message);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            Display();
        }
    }
}
