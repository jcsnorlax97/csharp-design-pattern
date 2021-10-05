using DesignPattern.Strategy.SimUDuck.FlyBehaviors;

namespace DesignPattern.Strategy.SimUDuck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _flyBehavior = new FlyWithWings();
        }
    }
}
