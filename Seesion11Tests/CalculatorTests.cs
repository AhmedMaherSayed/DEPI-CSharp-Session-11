using Session_11;

namespace Seesion11Tests
{
    public class CalculatorTests
    {
        private readonly CalculatorApp _calculator;
        public CalculatorTests()
        {
            _calculator = new CalculatorApp();
        }
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            // AAA (Arrange - Act - Assert)

            // Arrange
            int a = 5;
            int b = 3;

            // Act
            var result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(8, result);
        }
        [Fact]
        public void Add_ShouldReturnNotEqual()
        {
            // AAA (Arrange - Act - Assert)

            // Arrange
            int a = 5;
            int b = 3;

            // Act
            var result = _calculator.Add(a, b);

            // Assert
            Assert.NotEqual(12, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            //Assert.Equal(6, _calculator.Subtract(10, 4));

            // Arrange
            int a = 10;
            int b = 4;


            // Act
            var result = _calculator.Subtract(a, b);

            // Assert
            Assert.Equal(6, result);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(4, 5, 20)]
        [InlineData(-2, 3, -6)]
        public void Multiply_ShouldReturnCorrectMultiplicationResult(int a, int b, int expected)
        {
            // Arrange
            // Act
            var result = _calculator.Multiply(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 3, 2)]
        [InlineData(4, 5, 120)]
        [InlineData(-2, 3, -16)]
        public void Multiply_ShouldReturnNotEqual(int a, int b, int expected)
        {
            // Arrange
            // Act
            var result = _calculator.Multiply(a, b);

            // Assert
            Assert.NotEqual(expected, result);
        }

        // MethName_Condition_ExpectedResult
        [Fact]
        public void Divide_ByZero_ShouldThrowException()
        {
            // Arrange
            int a = 2;
            int b = 0;

            //// Act
            //var actual = _calculator.Divide(a, b);

            // Assert

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
        }

    }
}