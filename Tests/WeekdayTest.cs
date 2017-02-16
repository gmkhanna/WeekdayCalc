using Xunit;
using System.Collections.Generic;
using System;

namespace WeekdayCalc
{
    public class WeekdayTest
    {
        [Fact]
        public void Test1_LastTwoDigits_Output()
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
    }
}
