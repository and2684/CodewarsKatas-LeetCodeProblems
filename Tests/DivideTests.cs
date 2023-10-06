using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class DivideTests
    {
        private Solution? _solution;

        public Solution? solution { get => _solution; }

        [SetUp]
        public void Setup()
        {
            _solution = new Solution();
        }

        public Solution? Get_solution()
        {
            return _solution;
        }

        [Test]
        public void Divide_WhenDividendIsMinValueAndDivisorIsNegativeOne_ReturnsMaxValue()
        {
            // Arrange
            int dividend = int.MinValue;
            int divisor = -1;
            int expected = int.MaxValue;

            // Act
            int result = solution!.Divide(dividend, divisor);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_WhenDivisorIsOne_ReturnsDividend()
        {
            // Arrange
            int dividend = 10;
            int divisor = 1;
            int expected = dividend;

            // Act
            int result = solution!.Divide(dividend, divisor);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestCase(100, 0, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(-323230, 0, 0)]
        public void Divide_WhenDivisorIsZero_ReturnsZero(int dividend, int divisor, int expected)
        {
            // Act
            int result = solution!.Divide(dividend, divisor);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}