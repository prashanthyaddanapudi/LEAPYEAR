using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace IsItALeapYear.Tests
{
    [TestClass]
    public class IsItALeapYearTests
    {
        [TestMethod]
        public void Year_2001_Is_not_a_leap_year()
        {
            // Arrange
            var isItALeapYearServices = new IsItALeapYearServices();
            var expectedResult = false;
            // Act
            var actualResult = isItALeapYearServices.IsItALeapYear(2001);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Year_1996_Is_a_leap_year()
        {
            // Arrange
            int testValue= 1996;
            var isItALeapYearServices = new IsItALeapYearServices();
            var expectedResult = true;
            // Act
            var actualResult = isItALeapYearServices.IsItALeapYear(testValue);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Year_1900_is_not_a_leap_year()
        {
            // Arrange
            int testValue= 1900;
            var isItALeapYearServices = new IsItALeapYearServices();
            var expectedResult = false;
            // Act
            var actualResult = isItALeapYearServices.IsItALeapYear(testValue);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Year_2000_is_a_leap_year()
        {
            // Arrange
            int testValue= 2000;
            var isItALeapYearServices = new IsItALeapYearServices();
            var expectedResult = true;
            // Act
            var actualResult = isItALeapYearServices.IsItALeapYear(testValue);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
