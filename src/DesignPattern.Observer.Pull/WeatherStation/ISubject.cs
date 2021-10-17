using DesignPattern.Observer.Pull.WeatherStation.Observers;

namespace DesignPattern.Observer.Pull.WeatherStation
{
    public interface ISubject
    {
        public void RegisterObserver(IObserver o);
        public void RemoveObserver(IObserver o);
        public void NotifyObservers();
    }
}
