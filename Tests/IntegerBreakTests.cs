using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class IntegerBreakTests
    {
        private Solution? _solution;
        public Solution? solution { get => _solution; }

        [SetUp]
        public void Setup()
        {
            _solution = new Solution();
        }

        [TestCase(2, 1)]
        [TestCase(10, 36)]
        [TestCase(8, 18)]
        public void IntegerBreakLeetCodeTests(int number, int expected)
        {
            // Act
            int result = solution!.IntegerBreak(number);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
