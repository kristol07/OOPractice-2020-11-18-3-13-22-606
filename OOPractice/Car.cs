namespace OOPractice
{
    using System;

    public class Car : Vehicle
    {
        private string name;

        public Car(string name, double speed) : base(name, speed)
        {
        }

        public Car(string name, Engine engine) : base(name, engine.GetSpeed())
        {
        }
    }
}
