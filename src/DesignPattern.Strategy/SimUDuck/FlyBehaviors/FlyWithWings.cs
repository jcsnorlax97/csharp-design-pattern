using System;

namespace DesignPattern.Strategy.SimUDuck.FlyBehaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("[*][FlyingWithWings]");
        }
    }
}
