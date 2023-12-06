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
        [InlineData(new int[] { 4, 6, 5, 9, 3, 7 }, new int[] { 0, 0, 2 }, new int[] { 2, 3, 5 }, new bool[] { true, false, true })]
        public void CheckArithmeticSubarrays(int[] nums, int[] l, int[] r, bool[] expected)
        {
            var res = _solution.CheckArithmeticSubarrays(nums, l, r);

            Assert.Equal(expected, res);
        }

        [Theory]
        [MemberData(nameof(PartitionTestData))]
        public void PartitionTest(string s, List<List<string>> expected)
        {
            var res = _solution.Partition(s);

            Assert.Equal(expected, res);
        }

        public static IEnumerable<object[]> PartitionTestData()
        {
            yield return new object[]
            {
                "aab",
                new List<List<string>>
                {
                    new List<string> { "a", "a", "b" },
                    new List<string> { "aa", "b" }
                }
            };

            yield return new object[]
            {
                "aaab",
                new List<List<string>>
                {
                    new List<string> { "a", "a", "a", "b" },
                    new List<string> { "a", "aa", "b" },
                    new List<string> { "aa", "a", "b" },
                    new List<string> { "aaa", "b" }
                }
            };

            yield return new object[]
            {
                "abcaa",
                new List<List<string>>
                {
                    new List<string> { "a", "b", "c", "a", "a" },
                    new List<string> { "a", "b", "c", "aa" }
                }
            };

            yield return new object[]
            {
                "abbab",
                new List<List<string>>
                {
                    new List<string> { "a", "b", "b", "a", "b" },
                    new List<string> { "a", "b", "bab" },
                    new List<string> { "a", "bb", "a", "b" },
                    new List<string> { "abba", "b" }
                }
            };

            yield return new object[]
            {
                "abaca",
                new List<List<string>>
                {
                    new List<string> { "a", "b", "a", "c", "a" },
                    new List<string> { "a", "b", "aca" },
                    new List<string> { "aba", "c", "a" }
                }
            };

            yield return new object[]
            {
                "aaa",
                new List<List<string>>
                {
                    new List<string> { "a", "a", "a" },
                    new List<string> { "a", "aa" },
                    new List<string> { "aa", "a" },
                    new List<string> { "aaa" }
                }
            };
        }
    }
}
