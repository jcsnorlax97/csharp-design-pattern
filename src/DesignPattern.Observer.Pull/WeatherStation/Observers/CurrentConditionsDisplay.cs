using System;

namespace DesignPattern.Observer.Pull.WeatherStation.Observers
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        // --------------------------------------------------
        // IObserver
        // --------------------------------------------------
        public void Update()
        {
            if (_weatherData.GetType() == typeof(WeatherData))
            {
                WeatherData weatherData = (WeatherData)_weatherData;
                _temperature = weatherData.GetTemperature();
                _humidity = weatherData.GetHumidity();
                Display();
            }
        }

        // --------------------------------------------------
        // IDisplayElement
        // --------------------------------------------------
        public void Display()
        {
            Console.WriteLine($"[*][Current conditions: {_temperature}F degrees and {_humidity}% humidity.]");
        }
    }
}
