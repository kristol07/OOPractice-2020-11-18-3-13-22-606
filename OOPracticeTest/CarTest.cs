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
}
