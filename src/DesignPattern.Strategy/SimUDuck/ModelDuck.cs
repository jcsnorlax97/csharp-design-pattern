using DesignPattern.Strategy.SimUDuck.FlyBehaviors;
using DesignPattern.Strategy.SimUDuck.QuackBehaviors;
using System;

namespace DesignPattern.Strategy.SimUDuck
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new NormalQuack();
        }

        public override void Display()
        {
            Console.WriteLine("[*][Model Duck]");
        }
    }
}
