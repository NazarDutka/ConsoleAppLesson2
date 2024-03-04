using MyCalculationClassLibrary;

namespace MyCalculationClassLibrary.Tests
{
    [TestClass]
    public class LinqDemoTest
    {
        [TestMethod]
        public void TryParseAndSum_ShouldReturnSum()
        {
            // Arrange
            string input = "5 95 0";
            int expectedResult = 100;

            // Act
            var result = LinqDemo.TryParseAndSum(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow("5 95 0", 100)]
        [DataRow("2   one -1", 1)]
        [DataRow("5950  f, false true", 5950)]
        [DataRow(null, 0)]
        public void TryParseAndSum_ShouldReturnSumForDifferentStringsS(string input, int expectedResult)
        {
            // Arrange

            // Act
            var result = LinqDemo.TryParseAndSum(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}