using System;

namespace DesignPattern.Observer.Push.WeatherStation.Observers
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private int _counter;
        private float _minTemperature;
        private float _maxTemperature;
        private float _avgTemperature;
        private ISubject _weatherData;

        public StatisticsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
            _counter = 0;
        }

        // --------------------------------------------------
        // IObserver
        // --------------------------------------------------
        public void Update(float temperature, float humidity, float pressure)
        {
            if (_counter > 0)
            {
                _avgTemperature = (_counter * _avgTemperature + temperature) / (_counter + 1);
                _minTemperature = temperature < _minTemperature ? temperature : _minTemperature;
                _maxTemperature = temperature > _maxTemperature ? temperature : _maxTemperature;
            }
            else if (_counter == 0)
            {
                _avgTemperature = temperature;
                _minTemperature = temperature;
                _maxTemperature = temperature;
            }
            _counter++;
            Display();
        }

        // --------------------------------------------------
        // IDisplayElement
        // --------------------------------------------------
        public void Display()
        {
            Console.WriteLine($"[*][Avg/Max/Min temperature = {_avgTemperature}/{_maxTemperature}/{_minTemperature}");
        }
    }
}
