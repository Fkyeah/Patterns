using Observer.Interfaces;
using System;

namespace Observer.Observers
{
    public class AveragesConditionDisplay : IObserver, IDisplayElement
    {
        public AveragesConditionDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        private ISubject _weatherData;
        private float _maxTemperature;
        private float _avgTemperature;
        private float _minTemperature;

        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nAveragesConditionDisplay:");
            Console.WriteLine("Max temperature - {0}", _maxTemperature);
            Console.WriteLine("Average temperature - {0}", _avgTemperature);
            Console.WriteLine("Min temperature - {0}", _minTemperature);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            if (_minTemperature == 0)
                _minTemperature = temperature;

            if (temperature > _maxTemperature)
                _maxTemperature = temperature;
            else if (temperature < _minTemperature)
                _minTemperature = temperature;

            _avgTemperature = (_maxTemperature + _minTemperature) / 2;

            Display();
        }
    }
}
