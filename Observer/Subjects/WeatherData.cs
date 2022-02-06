using Observer.Interfaces;
using System.Collections.Generic;

namespace Observer.Subjects
{
    public class WeatherData : ISubject
    {
        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        private List<IObserver> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        private void MeasurementChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementChanged();
        }
    }
}
