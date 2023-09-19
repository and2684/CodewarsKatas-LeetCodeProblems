using System.Collections;
using System.Collections.Immutable;
using System.Text;

namespace hw
{
    #region some leetcode stuff
    public static class TwoSumSolution
    {
        public static int[]? TwoSum(int[] nums, int target)
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

    public static class LengthOfLongestSubstringSolution
    {
        public static int LengthOfLongestSubstring(string s)
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

    public static class SolutionRemoveDuplicates
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 1) return nums.Length;
            var notGoodOnes = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    nums[i - 1] = 9999;
                    notGoodOnes++;
                }
            }
            Array.Sort(nums);
            return nums.Length - notGoodOnes;
        }
    }

    public static class SolutionValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            s = new String(s.Where(char.IsLetterOrDigit).ToArray()).ToUpper();
            return s == new String(s?.ToCharArray().Reverse().ToArray()); ;
        }
    }

    public static class SolutionIsAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            return new String(s.OrderBy(x => x).ToArray()) == new String(t.OrderBy(x => x).ToArray());
        }
    }

    public static class SolutionLongestCommonPrefix
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            var lowestCharCount = Int32.MaxValue;
            var res = "";

            foreach (var str in strs)
            {
                if (str.Length < lowestCharCount)
                {
                    lowestCharCount = str.Length;
                    res = str;
                }
            }

            foreach (var str in strs)
            {
                while (str.Substring(0, lowestCharCount) != res)
                {
                    lowestCharCount--;
                    res = res.Substring(0, lowestCharCount);
                }
            }

            return res;
        }
    }

    public static class SolutionKthLargest
    {
        public static int FindKthLargest(int[] nums, int k)
        {
            //return nums.OrderByDescending(x => x).Skip(k - 1).First(); // Вариант в 1 строку

            // Вариант с очередью приоритетов
            var pq = new PriorityQueue<int, int>();
            foreach (var item in nums)
            {
                pq.Enqueue(item, item);
                if (pq.Count > k) pq.Dequeue();
            }

            return pq.Dequeue();
        }
    }

    public static class SolutionRemoveElement
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int res = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    res++;
                    nums[i] = 0;
                }
            }

            Comparison<int> a = delegate (int x, int y) { return y - x; };
            Array.Sort(nums, a);
            return res;
        }
    }


    //* Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public static class SolutionCanPlaceFlowers
    {
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            if (n == 0) return true;
            if (!flowerbed.Contains(0)) return false;
            if (flowerbed.Length == 1 & n == 1 & flowerbed[0] == 0) return true;

            int res = 0;
            var sb = new StringBuilder();
            sb.AppendJoin("", flowerbed);

            var s = sb.ToString();
            if (s.StartsWith("00"))
            {
                s = "10" + s.Remove(0, 2);
                res++;
            }

            if (s.EndsWith("00"))
            {
                s = s.Remove(s.Length - 2, 2) + "01";
                res++;
            }

            while (s.Contains("000"))
            {
                s = s.Remove(s.IndexOf("000")) + "020" + s.Substring(s.IndexOf("000") + 3);
            }

            res = res + s.Where(x => x == '2').Count();

            return n <= res;
        }
    }

    public static class SolutionRepeatedSubstringPattern
    {
        public static bool RepeatedSubstringPattern(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1) { return false; }

            for (int i = 1; i <= s.Length / 2; i++)
            {
                if (!s.Replace(s.Substring(0, i), "").Any()) { return true; };
            }

            return false;
        }
    }

    public class PisosComparer<T> : IComparer<T>
    {
        public int Compare(T? x, T? y)
        {
            if (x?.ToString() == "Vovkin pisos") { return -1; }
            if (y?.ToString() == "Vovkin pisos") { return 1; }

            var defaultComparer = new CaseInsensitiveComparer();
            return defaultComparer.Compare(x, y);
        }
    }

    public static class PisosComparerQ
    {
        public static void PisosComaparing()
        {
            var Q = new PriorityQueue<string, string>(0, new PisosComparer<string>());
            Q.Enqueue("Vova", "Vovkin pisos");
            Q.Enqueue("Gigachad", "Big donger");
            Q.Enqueue("Pepe", "Small pepe");
            Q.Enqueue("Chuvak", "Middle thing");

            while (Q.Count > 0)
            {
                Console.WriteLine(Q.Dequeue());
            }
        }
    }

    public static class SolutionRotate
    {
        public static void Rotate(int[] nums, int k)
        {
            if (nums.Length < 2) { return; }
            while (nums.Length < k)
            {
                k = k - nums.Length;
            }

            // Циклом медленно, не проходит последние проверки
            //for (int i = 0; i < k; i++)
            //{
            //    var temp = nums[nums.Length - 1];

            //    for (int j = nums.Length - 1; j > 0; j--)
            //    {
            //        nums[j] = nums[j - 1];
            //    }
            //    nums[0] = temp;
            //}

            // Линком быстрее
            var arr = nums.Take(new Range(nums.Length - k, nums.Length)).Concat(nums.SkipLast(k)).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = arr[i];
            }
        }
    }

    public static class SolutionLongestPalindrome
    {
        public static string LongestPalindrome(string s)
        {
            static bool IsPalindrome(string input, int left, int right)
            {
                while (left < right)
                {
                    if (input[left] != input[right])
                        return false;
                    left++;
                    right--;
                }
                return true;
            }

            for (int i = 0; i < s.Length; i++)
            {
                for (int leftPad = 0; leftPad <= i; leftPad++)
                {
                    int rightPad = i - leftPad;
                    if (IsPalindrome(s, leftPad, s.Length - 1 - rightPad))
                        return s.Substring(leftPad, s.Length - rightPad - leftPad);
                }
            }

            return "";
        }
    }

    public static class SolutionLongestConsecutive
    {
        public static int LongestConsecutive(int[] nums)
        {
            int res = 1;
            int len = 1;
            Array.Sort(nums.Distinct().ToArray());
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1]) continue;
                if (nums[i] + 1 == nums[i + 1])
                {
                    len++;
                }
                else
                {
                    len = 1;
                }

                if (res < len) res = len;
            }
            return res;
        }
    }

    public static class SolutionMaxSubArray
    {
        public static int MaxSubArray(int[] nums)
        {
            int max = nums[0];
            int cur = 0;

            foreach (var item in nums)
            {
                if (cur < 0) cur = 0;
                cur += item;
                max = Math.Max(max, cur);
            }
            return max;

            // Слишком медленно
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int leftPad = 0; leftPad <= i; leftPad++)
            //    {
            //        int rightPad = i - leftPad;
            //        if (nums[leftPad] < 0 || nums[nums.Length - 1 - rightPad] < 0) continue;
            //        max = Math.Max(nums.Skip(leftPad).SkipLast(rightPad).Sum(), max);
            //    }
            //}
            //return max;
        }
    }

    public static class SolutionProductExceptSelf
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            var res = new int[nums.Length];

            var leftSide = 1;
            var rightSide = 1;

            for (var i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    res[i] = 1;
                    continue;
                }
                leftSide *= nums[i - 1];
                res[i] = leftSide;
            }

            for (int i = nums.Length - 2; i >= 0; i--)
            {
                rightSide *= nums[i + 1];
                res[i] *= rightSide;
            }

            return res;
        }
    }

    public static class SolutionIsInterleave
    {
        public static bool IsInterleave(string s1, string s2, string s3)
        {
            if (s3.Length != s1.Length + s2.Length) return false;
            int pointerS1 = 0;
            int pointerS2 = 0;
            int i = 0;
            while (i < s3.Length)
            {
                int oldi = i;
                while (pointerS1 < s1.Length && s3[i] == s1[pointerS1])
                {
                    i++;
                    pointerS1++;
                }
                if (i < s3.Length)
                {
                    while (pointerS2 < s2.Length && s3[i] == s2[pointerS2])
                    {
                        i++;
                        pointerS2++;
                    }
                }
                if (i == oldi) break;
            }
            return i >= s3.Length;
        }
    }

    public static class SolutionMoveZeroes
    {
        public static void MoveZeroes(int[] nums)
        {
            var res = nums.Where(x => x != 0).Concat(nums.Where(x => x == 0)).ToArray();
            int i = 0;
            foreach (var item in res)
            {
                nums[i] = item;
                i++;
            }
        }
    }

    public static class SolutionRemoveElement2
    {
        public static int RemoveElement2(int[] nums, int val)
        {
            var res = nums.Count();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    nums[i] = 9999;
                    res--;
                }
            }
            Array.Sort(nums);
            return res;
        }
    }

    public static class SolutionStrStr
    {
        public static int StrStr(string haystack, string needle)
        {
            if (haystack.Length < needle.Length) return -1;
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if(haystack.Substring(i, needle.Length) == needle) return i;
            }
            return -1;
        }
    }

    public static class Solution
    {
        public static int SearchInsert(int[] nums, int target)
        {
            if (target <= nums[0]) return 0;
            if (target > nums[nums.Length - 1]) return nums.Length;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == target) return i;
                if (nums[i] < target && nums[i + 1] >= target) return i + 1;
            }
            return nums.Length;
        }
    }

    public static class SolutionFindMedianSortedArrays
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var merged = nums1.Concat(nums2).ToArray();
            Array.Sort(merged);

            int length = merged.Length;
            int middleIndex = length / 2;

            if (length % 2 == 0) // Если число элементов четное
            {
                int middleIndex1 = middleIndex - 1;
                int middleIndex2 = middleIndex;
                double median = (merged[middleIndex1] + merged[middleIndex2]) / 2.0;
                return median;
            }
            else // Если число элементов нечетное
            {
                double median = merged[middleIndex];
                return median;
            }
        }
    }

    public static class SolutionLengthOfLastWord
    {
        public static int LengthOfLastWord(string s)
        {
            return s.Trim().Reverse().TakeWhile(x => x != ' ').Count();
        }
    }

    public static class SolutionPlusOne
    {
        public static int[] PlusOne(int[] digits)
        {
            // Не хватило размерности decimal, а жаль, решение прикольное же :)
            //decimal res = 0;
            //int exp = 0;
            //foreach (var digit in digits.Reverse()) 
            //{
            //    res = res + (decimal)(digit * Math.Pow(10, exp));
            //    exp++;
            //}
            //res++;
            //return res.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();

            var list = new List<int>(digits.Length + 1);
            var NeedAddition = true;
            foreach (int i in digits.Reverse())
            {
                if (i == 9 && NeedAddition)
                {
                    list.Add(0);
                    continue;
                }
                if (NeedAddition)
                {
                     list.Add(i + 1);
                     NeedAddition = false;
                }
                else
                {
                    list.Add(i);
                }
            }
            if (NeedAddition) list.Add(1);
            list.Reverse();
            return list.ToArray();
        }
    }

}
#endregion
