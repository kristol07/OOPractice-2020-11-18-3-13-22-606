namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class CarTest
    {
        [Fact]
        public void Should_Show_Message_With_Name_And_Speed_When_Speedup()
        {
            //given
            string expected = "Cool Car: speed up 30 km/h";
            Car car = new Car("Cool Car", 30);

            //when
            string actual = car.SpeedUp();

            //then
            Assert.Equal(expected, actual);
        }
    }

    public class TruckTest
    {
        [Fact]
        public void Should_Show_Message_With_Name_And_Speed_When_Speedup()
        {
            //given
            string expected = "Big Truck: speed up 10 km/h";
            Truck truck = new Truck("Big Truck", 10);

            //when
            string actual = truck.SpeedUp();

            //then
            Assert.Equal(expected, actual);
        }
    }
}
