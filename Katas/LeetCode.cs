using System.Collections.Immutable;

namespace hw
{
    #region some leetcode stuff
    public class TwoSumSolution
    {
        public int[]? TwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                    if ((nums[i] + nums[j] == target) & (i != j))
                    {
                        return new int[] { i, j };
                    }
            }
            return null;
        }
    }

    public class LengthOfLongestSubstringSolution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int res = 0;
            var resDict = new Dictionary<int, char>(50000);

            int starter = 0;
            for (int i = starter; i < s.Length; i++)
            {
                if (!resDict.Values.Contains(s[i]))
                {
                    resDict.Add(i, s[i]);
                    if (res < resDict.Count) { res = resDict.Count; }
                }
                else
                {
                    i = resDict.First(x => x.Value == s[i]).Key;
                    resDict.Clear();
                }
            }
            resDict.Clear();

            return res;
        }
    }

    public static class SolutionValidParentheses
    {
        public static bool IsValid(string s)
        {
            if (s.Length % 2 != 0) return false;

            while (s.Contains("()") | s.Contains("[]") | s.Contains("{}"))
            {
                s = s.Replace("()", "").Replace("[]", "").Replace("{}", "").ToString();
            }

            return (s.Length == 0);
        }
    }

    public static class SolutionPow
    {
        public static double MyPow(double x, int n)
        {
            if (n == 0) return 1;
            if (n == 1) return x;
            if (x == 1) return 1;
            if (x == -1)
            {
                if (n % 2 == 0) return 1;
                else return -1;
            }

            var basex = x;

            if (n > 1)
            {
                while (n != 1)
                {
                    x = x * basex;
                    n--;
                }
                return x;
            }
            else
            {
                while (n != -1)
                {
                    x = x * basex;
                    n++;
                }
                x = Math.Round(1 / x, 4);
                return x;
            }
        }
    }

    public static class SolutionIsPalindrome
    {
        public static bool IsPalindrome(int x)
        {
            var s = x.ToString();
            var reverse = new System.Text.StringBuilder(s.Length);
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverse.Append(s[i]);
            }

            return s == reverse.ToString();
        }
    }

    public static class SolutionSearchMatrix
    {
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            if (target < matrix[0][0]) return false;
            if (target > matrix[matrix.Length - 1][matrix[0].Length - 1]) return false;

            int m = 0;
            int n = matrix[0].Length - 1;

            if (n > 0 & matrix.Length - 1 > 0)
            {
                while (m <= matrix.Length - 1 & n >= 0)
                {
                    if (matrix[m][n] == target) return true;
                    if (matrix[m][n] < target)
                    {
                        m++;
                        if (m > matrix.Length - 1) return false;
                        if (matrix[m][n] == target) return true;
                    }
                    if (matrix[m][n] > target)
                    {
                        n--;
                        if (n < 0) return false;
                        if (matrix[m][n] == target) return true;
                    }
                }
            }
            else if (n == 0)
            {
                while (m <= matrix.Length - 1)
                {
                    if (matrix[m][n] != target)
                    {
                        m++;
                    }
                    else return true;
                }
            }
            else
            {
                while (n >= 0)
                {
                    if (matrix[m][n] != target)
                    {
                        n--;
                    }
                    else return true;
                }
            }

            return false;
        }
    }

    public static class SolutionThreeSum
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            var res = new List<IList<int>>();
            Array.Sort(nums);
            var dublicate = false;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int j = i + 1;
                int k = nums.Length - 1;

                while (j != k)
                {
                    if (nums[j] + nums[k] == -nums[i])
                    {
                        var okValue = (new List<int> { nums[i], nums[j], nums[k] }).OrderBy(x => x).ToList();

                        foreach (var item in res)
                        {
                            if (item[0] == okValue[0] & item[1] == okValue[1] && item[2] == okValue[2])
                            {
                                dublicate = true;
                                break;
                            }
                        }

                        if (!dublicate) res.Add(okValue);
                        k--;
                        dublicate = false;
                    }
                    if (nums[j] + nums[k] > -nums[i]) k--;
                    else j++;
                }
            }

            return res;
        } 
    }

    public static class SolutionMerge
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < n; i++)
            {
                nums1[m + i] = nums2[i];
            }
            Array.Sort(nums1);
        }
    }
    #endregion
}
