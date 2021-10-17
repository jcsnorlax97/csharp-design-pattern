using DesignPattern.Observer.Pull.WeatherStation;
using DesignPattern.Observer.Pull.WeatherStation.Observers;

namespace DesignPattern.Observer.Pull
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Initialize Subjects & Observers
            WeatherData weatherData = new WeatherData(); // Subject (with State)
            CurrentConditionsDisplay _ = new CurrentConditionsDisplay(weatherData); // Observer

            // Simulate State Changes
            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);
        }
    }
}
