using System;

namespace DesignPattern.Strategy.SimUDuck.QuackBehaviors
{
    public class NormalQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("[*][Normal Quack]");
        }
    }
}
