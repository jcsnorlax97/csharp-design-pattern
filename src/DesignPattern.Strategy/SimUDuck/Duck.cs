using DesignPattern.Strategy.SimUDuck.FlyBehaviors;
using DesignPattern.Strategy.SimUDuck.QuackBehaviors;

namespace DesignPattern.Strategy.SimUDuck
{
    public abstract class Duck
    {
        protected IFlyBehavior _flyBehavior;
        protected IQuackBehavior _quackBehavior;

        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            _quackBehavior.Quack();
        }
    }
}
