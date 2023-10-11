using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class SearchInRotatedArrayTests
    {
        public Solution? Solution { get; set; }

        [SetUp]
        public void Setup()
        {
            Solution = new Solution();
        }

        [TestCase(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
        [TestCase(new int[] { 3, 1}, 1, 1)]
        [TestCase(new int[] { 3, 5, 1 }, 1, 2)]
        public void TestSearchInRotatedArray(int[] nums, int target, int expected)
        {
            // Act
            var result = Solution!.Search(nums, target);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}