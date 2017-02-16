using Xunit;
using System.Collections.Generic;
using System;

namespace WeekdayCalc
{
    public class WeekdayTest
    {
        [Fact]
        public void Test1_LastTwoDigits_17()
        {
            //Arrange
            string userInput = "02/16/2017";
            int testResult = 17;

            //Act
            Weekday newWeekday = new Weekday(userInput);
            int result = newWeekday.GetParsedYear();

            //Assert
                          //Arrange  //Act
            Assert.Equal(testResult, result);
        }

        [Fact]
        public void Test2_DividebyFour_4()
        {
            //Arrange
            string userInput = "02/16/2017";
            int testResult = 4;

            //Act
            Weekday newWeekday = new Weekday(userInput);
            int result = newWeekday.GetDividedYear();

            //Assert
            Assert.Equal(testResult, result);
        }

        [Fact]
        public void Test3_RemainderTest_1()
        {
            //Arrange
            string userInput = "02/16/2017";
            int testResult = 1;

            //Act
            Weekday newWeekday = new Weekday(userInput);
            int result = newWeekday.GetRemainder();

            //Assert
            Assert.Equal(testResult, result);
        }

        [Fact]
        public void Test4_AddDaytoDividedYear_20()
        {
            //Arrange
            string userInput = "02/16/2017";
            int testResult = 20;

            //Act
            Weekday newWeekday = new Weekday(userInput);
            int result = newWeekday.GetDayPlusYear();

            //Assert
            Assert.Equal(testResult, result);
        }

        [Fact]
        public void Test5_AddMonthValuetoDayplusYear_24()
        {
            //Arrange
            string userInput = "02/16/2017";
            int testResult = 24;

            //Act
            Weekday newWeekday = new Weekday(userInput);
            int result = newWeekday.GetAfterMonthValue();

            //Assert
            Assert.Equal(testResult, result);
        }

        [Fact]
        public void Test6_LeapYearTest_24()
        {
            //Arrange
            string userInput = "02/16/2017";
            int testResult = 24;

            //Act
            Weekday newWeekday = new Weekday(userInput);
            int result = newWeekday.GetAfterMonthValue();

            //Assert
            Assert.Equal(testResult, result);
        }
    }
}
