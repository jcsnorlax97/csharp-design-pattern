using DesignPattern.Strategy.SimUDuck.FlyBehaviors;

namespace DesignPattern.Strategy.SimUDuck
{
    public abstract class Duck
    {
        protected IFlyBehavior _flyBehavior;

        public void PerformFly()
        {
            _flyBehavior.Fly();
        }
    }
}
