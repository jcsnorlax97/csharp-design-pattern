using DesignPattern.Strategy.SimUDuck;
using DesignPattern.Strategy.SimUDuck.FlyBehaviors;
using System;

namespace DesignPattern.Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SimulateMiniDuck();
        }

        public static void SimulateMiniDuck()
        {
            Duck mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformFly();
            mallard.PerformQuack();
            Console.WriteLine("");

            Duck model = new ModelDuck();
            model.Display();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
            Console.WriteLine("");
        }
    }
}
