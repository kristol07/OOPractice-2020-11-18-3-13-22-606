using OOPractice;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OOPracticeTest
{
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
