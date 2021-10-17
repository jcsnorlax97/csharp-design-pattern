using DesignPattern.Observer.Push.WeatherStation.Observers;
using System.Collections;

namespace DesignPattern.Observer.Push.WeatherStation
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
                observer.Update(_temperature, _humidity, _pressure);
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
    }
}
