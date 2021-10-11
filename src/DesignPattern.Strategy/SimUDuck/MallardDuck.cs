using DesignPattern.Strategy.SimUDuck.FlyBehaviors;
using DesignPattern.Strategy.SimUDuck.QuackBehaviors;

namespace DesignPattern.Strategy.SimUDuck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _flyBehavior = new FlyWithWings();
            _quackBehavior = new NormalQuack();
        }
    }
}
