using System;
using System.Collections.Generic;
using System.Text;

namespace OOPractice
{
    public class Truck
    {
        private string name;
        private double speed;

        public Truck(string name, double speed)
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
