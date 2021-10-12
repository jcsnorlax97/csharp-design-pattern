using DesignPattern.Observer.Push.WeatherStation.Observers;

namespace DesignPattern.Observer.Push.WeatherStation
{
    public interface ISubject
    {
        public void RegisterObserver(IObserver o);
        public void RemoveObserver(IObserver o);
        public void NotifyObservers();
    }
}
