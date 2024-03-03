using MyCalculationClassLibrary;

namespace MyCalculationClassLibrary.Tests
{
    [TestClass]
    public class MathematicsTest
    {
        [TestMethod]
        public void Sum_ShouldReturnSum()
        {
            // Arrange
            int number1 = 5;
            int number2 = 10;
            int expectedResult = number1 + number2;

            // Act
            var result = Mathematics.Sum(number1, number2);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(-1, 1, 0)]
        [DataRow(3, 5, 8)]
        [DataRow(-16, -4, -20)]
        public void SumOfTwo_ShouldReturnSum(int number1, int number2, int expectedResult)
        {
            // Arrange

            // Act
            var result = Mathematics.Sum(number1, number2);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(-5, 5, 0, 0)]
        [DataRow(3, 5, 999, 1007)]
        [DataRow(-199, -4, -2, -205)]
        public void SumOfThree_ShouldReturnSum(int number1, int number2, int number3, int expectedResult)
        {
            // Arrange

            // Act
            var result = Mathematics.Sum(number1, number2, number3);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}