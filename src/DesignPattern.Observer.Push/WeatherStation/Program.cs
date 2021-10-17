using DesignPattern.Observer.Push.WeatherStation;
using DesignPattern.Observer.Push.WeatherStation.Observers;

namespace DesignPattern.Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Inititalize Subjects & Observers
            WeatherData weatherData = new WeatherData(); // Subject (with State)
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData); // Observer
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData); // Observer

            // Simulate State Changes
            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);
        }
    }
}
