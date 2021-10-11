using DesignPattern.Strategy.SimUDuck.FlyBehaviors;
using DesignPattern.Strategy.SimUDuck.QuackBehaviors;

namespace DesignPattern.Strategy.SimUDuck
{
    public abstract class Duck
    {
        protected IFlyBehavior _flyBehavior;
        protected IQuackBehavior _quackBehavior;

        // --------------------------------------------------
        // Behaviors - Delegate Function
        // --------------------------------------------------
        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            _quackBehavior.Quack();
        }

        // --------------------------------------------------
        // Others
        // --------------------------------------------------
        public abstract void Display();

        // --------------------------------------------------
        // Mutators - Setting Behavior Dynamically
        // --------------------------------------------------
        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            _quackBehavior = quackBehavior;
        }
    }
}
