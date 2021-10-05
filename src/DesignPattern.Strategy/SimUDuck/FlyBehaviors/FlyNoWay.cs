using System;

namespace DesignPattern.Strategy.SimUDuck.FlyBehaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("[*][FlyNoWay]");
        }
    }
}
