namespace OOPractice
{
    using System;

    public class Car
    {
        private string name;
        private double speed;

        public Car(string name, double speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public string SpeedUp()
        {
            return $"{name}: speed up {speed} km/h";
        }
    }
}
