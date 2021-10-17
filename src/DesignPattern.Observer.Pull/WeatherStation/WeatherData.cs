using DesignPattern.Observer.Pull.WeatherStation.Observers;
using System.Collections;

namespace DesignPattern.Observer.Pull.WeatherStation
{
    public class WeatherData : ISubject
    {
        private ArrayList _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new ArrayList();
        }

        // --------------------------------------------------
        // Implementations of Subject Interface
        // --------------------------------------------------
        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            int i = _observers.IndexOf(o);
            if (i >= 0)
            {
                _observers.RemoveAt(i);
            }
        }

        public void NotifyObservers()
        {
            foreach (object o in _observers)
            {
                IObserver observer = (IObserver)o;
                observer.Update();
            }
        }

        // --------------------------------------------------
        // State Changes
        // --------------------------------------------------
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            NotifyObservers();
        }

        // --------------------------------------------------
        // Accessors
        // --------------------------------------------------
        public float GetTemperature()
        {
            return _temperature;
        }

        public float GetHumidity()
        {
            return _humidity;
        }

        public float GetPressure()
        {
            return _pressure;
        }
    }
}
