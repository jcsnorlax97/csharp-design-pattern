using DesignPattern.Strategy.SimUDuck;

namespace DesignPattern.Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SimulateMiniDuck();
        }

        /**
         * Interfaces: Duck, IFlyBehavior
         * Duck: (i) Has-A FlyBehavior
         * MallardDuck: Is-A Duck
         * IFlyBehavior: N/A
         * FlyWithWings & FlyNoWay: Is-A IFlyBehavior
         */
        public static void SimulateMiniDuck()
        {
            Duck mallard = new MallardDuck();
            mallard.PerformFly();
        }
    }
}
