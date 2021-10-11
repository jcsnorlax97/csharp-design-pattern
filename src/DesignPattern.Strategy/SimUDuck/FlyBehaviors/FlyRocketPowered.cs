using System;

namespace DesignPattern.Strategy.SimUDuck.FlyBehaviors
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("[*][FlyRocketPowered]");
        }
    }
}
