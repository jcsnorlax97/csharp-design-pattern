using System;

namespace DesignPattern.Strategy.SimUDuck.QuackBehaviors
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("[*][Squeak]");
        }
    }
}
