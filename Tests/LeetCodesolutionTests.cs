using Xunit;

namespace hw
{
    public class LeetCodesolutionTests
    {
        private readonly LeetCodeSolution _solution;

        public LeetCodesolutionTests()
        {
            _solution = new LeetCodeSolution();
        }

        [Theory]
        [InlineData("6777133339", "777")]
        [InlineData("2300019", "000")]
        [InlineData("42352338", "")]
        public void LargestGoodIntegerTest(string insert, string expected)
        {
            var res = _solution.LargestGoodInteger(insert);

            Assert.Equal(expected, res);
        }

        [Theory]
        [InlineData(new int[] { 4, 6, 5, 9, 3, 7 }, new int[] { 0, 0, 2 }, new int[] { 2, 3, 5 }, new bool[] { true, false, true } )]
        public void CheckArithmeticSubarrays(int[] nums, int[] l, int[] r, bool[] expected)
        {
            var res = _solution.CheckArithmeticSubarrays(nums, l, r);

            Assert.Equal(expected, res);
        }
    }
}
