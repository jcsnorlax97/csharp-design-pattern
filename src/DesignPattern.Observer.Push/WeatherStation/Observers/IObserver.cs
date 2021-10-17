namespace DesignPattern.Observer.Push.WeatherStation.Observers
{
    public interface IObserver
    {
        public void Update(float temp, float humidity, float pressure);
    }
}
