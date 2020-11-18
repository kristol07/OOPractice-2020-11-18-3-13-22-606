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

        [Fact]
        public void Should_Show_Message_With_Different_Speed_When_Using_Electric_Engine()
        {
            //given
            string expected = "Cool Car: speed up 25 km/h";
            Engine engine = new Engine("electric");
            Car car = new Car("Cool Car", engine);

            //when
            string actual = car.SpeedUp();

            //then
            Assert.Equal(expected, actual);
        }
    }
}
