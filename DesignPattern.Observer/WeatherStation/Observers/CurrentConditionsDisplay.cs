﻿using System;

namespace DesignPattern.Observer.Push.WeatherStation.Observers
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        // --------------------------------------------------
        // IObserver
        // --------------------------------------------------
        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            Display();
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