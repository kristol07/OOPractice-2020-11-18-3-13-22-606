namespace OOPractice
{
    public class Vehicle
    {
        private string name;
        private double speed;

        public Vehicle(string name, double speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public virtual string SpeedUp()
        {
            return $"{name}: speed up {speed} km/h";
        }
    }
}