using System;

namespace DesignPattern.Strategy.SimUDuck.QuackBehaviors
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("[*][<< Silence >>]");
        }
    }
}
