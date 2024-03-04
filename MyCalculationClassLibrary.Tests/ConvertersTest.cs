using MyCalculationClassLibrary;

namespace MyCalculationClassLibrary.Tests
{
    [TestClass]
    public class ConvertersTest
    {
        [TestMethod]
        public void ToInt_ShouldConvertEachItemToInt()
        {
            // Arrange
            var input = new[] { "5", "10" };
            int number1 = 5;
            int number2 = 10;
            var expectedResult = new[] { number1, number2 };

            // Act
            var result = Converters.ToInt(input);

            // Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]

        public void ToInt_ShouldReturnZeroIfConvertFails()
        {
            var strings = new[] { "one", "", "true" };
            var expectedResult = new[] { 0, 0, 0 };
            // Arrange

            // Act
            var result = Converters.ToInt(strings);

            // Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }
    }
}