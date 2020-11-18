using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using OOPractice;

namespace OOPracticeTest
{
    public class DriverTest
    {
        [Fact]
        public void Should_Show_Message_With_Name_And_Speed_When_Drive_Car()
        {
            //given
            string expected = "Cool Car: speed up 30 km/h";
            Car car = new Car("Cool Car", 30);
            Driver driver = new Driver(car);

            //when
            string actual = driver.Drive();

            //then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Show_Message_With_Name_And_Speed_When_Drive_Truck()
        {
            //given
            string expected = "Big Truck: speed up 10 km/h";
            Truck truck = new Truck("Big Truck", 10);
            Driver driver = new Driver(truck);

            //when
            string actual = driver.Drive();

            //then
            Assert.Equal(expected, actual);
        }
    }
}
