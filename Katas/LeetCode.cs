using hw;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
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
                        return new[] { i, j };
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
                s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
            }

            return (s.Length == 0);
        }
    }

    public static class SolutionPow
    {
        [SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator")]
        public static double MyPow(double x, int n)
        {
            if (n == 0) return 1;
            if (n == 1) return x;
            if (x == 1) return 1;
            if (x == -1)
            {
                if (n % 2 == 0) return 1;
                return -1;
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

            while (n != -1)
            {
                x = x * basex;
                n++;
            }
            x = Math.Round(1 / x, 4);
            return x;
        }
    }

    public static class SolutionIsPalindrome
    {
        public static bool IsPalindrome(int x)
        {
            var s = x.ToString();
            var reverse = new StringBuilder(s.Length);
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
            return s == new String(s.ToCharArray().Reverse().ToArray());
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
            //return nums.OrderByDescending(x => x).Skip(k - 1).First(); // ������� � 1 ������

            // ������� � �������� �����������
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
                if (!s.Replace(s.Substring(0, i), "").Any()) { return true; }
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

            // ������ ��������, �� �������� ��������� ��������
            //for (int i = 0; i < k; i++)
            //{
            //    var temp = nums[nums.Length - 1];

            //    for (int j = nums.Length - 1; j > 0; j--)
            //    {
            //        nums[j] = nums[j - 1];
            //    }
            //    nums[0] = temp;
            //}

            // ������ �������
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

            // ������� ��������
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
                if (haystack.Substring(i, needle.Length) == needle) return i;
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

            if (length % 2 == 0) // ���� ����� ��������� ������
            {
                int middleIndex1 = middleIndex - 1;
                int middleIndex2 = middleIndex;
                double median = (merged[middleIndex1] + merged[middleIndex2]) / 2.0;
                return median;
            }
            else // ���� ����� ��������� ��������
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
            // �� ������� ����������� decimal, � ����, ������� ���������� �� :)
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

    public static class SolutionConvertToTitle
    {
        public static string ConvertToTitle(int columnNumber)
        {
            Dictionary<int, char> dictionary = new Dictionary<int, char>(26);
            var i = 0;
            for (char c = 'A'; c <= 'Z'; c++)
            {
                dictionary.Add(++i, c);
            }

            var suffix = string.Empty;
            i = columnNumber % 26;
            if (i > 0)
            {
                suffix = dictionary[i].ToString();
                columnNumber = columnNumber - i;
            }

            var z = false;
            while (columnNumber >= 26)
            {
                columnNumber = columnNumber / 26;
                if (columnNumber >= 26)
                {
                    suffix = 'Z' + suffix;
                    z = true;
                }

                if (!z)
                {
                    suffix = dictionary[columnNumber] + suffix;
                }
            }

            return suffix;
        }
    }

    public static class SolutionSingleNumber
    {
        public static int SingleNumber(int[] nums)
        {
            var hs = new HashSet<int>(nums.Length);
            foreach (var i in nums)
            {
                if (hs.Contains(i))
                {
                    hs.Remove(i);
                }
                else
                {
                    hs.Add(i);
                }
            }
            return hs.FirstOrDefault();
        }
    }

    public static class SolutionLetterCombinations
    {
        public static IList<string> LetterCombinations(string digits)
        {
            var res = new List<string>();

            int[] keys = { 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 9, 9, 9, 9 };
            char[] values = new char[26];
            for (int i = 0; i < 26; i++)
            {
                values[i] = Convert.ToChar('a' + i);
            }

            var map = keys.Zip(values, (k, v) => new { Key = k, Value = v }).ToLookup(x => x.Key, x => x.Value);

            foreach (var digit in digits)
            {
                IGrouping<int, char> i = map.Where(x => x.Key == int.Parse(digit.ToString())).First();
                foreach (var item in i)
                {
                    res.Add(item.ToString());
                }
                res.Add(new string('-', 50)); // a
            }

            return res;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public static class SolutionInorderTraversal
    {
        public static List<int> res = new List<int>();
        public static IList<int> InorderTraversal(TreeNode? root)
        {
            if (root is null) return res;
            if (root.left is not null) InorderTraversal(root.left);
            res.Add(root.val);
            if (root.right is not null) InorderTraversal(root.right);
            return res;
        }
    }

    public class SolutionIsSameTree
    {
        bool res = true;
        public bool IsSameTree(TreeNode? p, TreeNode? q)
        {
            if (!res) return false;
            res = (p?.val == q?.val) && IsSameTree(p?.left, q?.left) && IsSameTree(p?.right, q?.right);
            return res;
        }
    }

    public class SolutionIsSymmetric
    {
        bool res = true;
        public bool IsSymmetric(TreeNode root)
        {
            if (!res) return false;
            res = IsLeftRightSymmetric(root, root);
            return res;
        }
        public bool IsLeftRightSymmetric(TreeNode? p, TreeNode? q)
        {
            if (p is null && q is null) return true;
            if (q is null && p is not null) return false;
            if (p is null && q is not null) return false;
            res = (p?.left?.val == q?.right?.val)
                   && IsLeftRightSymmetric(p?.left, q?.right)
                   && IsLeftRightSymmetric(p?.right, q?.left);
            return res;
        }
    }

    public class SolutionMaxDepth
    {
        int max = 1;
        public int MaxDepth(TreeNode? root)
        {
            if (root == null) return 0;
            max = Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
            return max;
        }
    }

    public static class SolutionNextPermutation
    {
        // �� ������ �� �������
        //public static void NextPermutation(int[] nums)
        //{
        //    var res = new HashSet<string>();
        //    var numsInt = long.Parse(string.Join("", nums));
        //    Permute(nums, 0, nums.Length - 1, res);

        //    var numsRes = res.OrderBy(x => x).Where(x => long.Parse(x) > numsInt).FirstOrDefault();
        //    if (numsRes is null)
        //        numsRes = res.OrderBy(x => x).First();

        //    var numsResArr = numsRes.Select(c => int.Parse(c.ToString())).ToArray();           
        //    numsResArr.CopyTo(nums, nums.Length - numsRes.Length);
        //}

        //static void Permute(int[] nums, int l, int r, HashSet<string> res)
        //{
        //    if (l == r)
        //    {
        //        var s = new StringBuilder(nums.Length);
        //        foreach (var item in nums)
        //        {
        //            s.Append(item.ToString());
        //        }
        //        res.Add(s.ToString());
        //    }
        //    else
        //    {
        //        for (int i = l; i <= r; i++)
        //        {
        //            (nums[l], nums[i]) = (nums[i], nums[l]); // ������ �������
        //            Permute(nums, l + 1, r, res);
        //            (nums[l], nums[i]) = (nums[i], nums[l]); // ��������������� �������� ���������
        //        }
        //    }
        //}

        public static void NextPermutation(int[] nums)
        {
            var i = nums.Length - 2;

            // ������ ������ ���� �������� ���������, ��� ����� ������� ������ ������� ��������
            while (i >= 0 && nums[i] >= nums[i + 1])
            {
                i--;
            }

            if (i >= 0)
            {
                var j = nums.Length - 1;

                //������ ���������� ������� � ���������� ������ �� ������� i, ������� ������ ����� nums[i]
                while (j >= 0 && nums[j] <= nums[i])
                {
                    j--;
                }

                // �������� ������� �������� � ��������� i � j
                (nums[i], nums[j]) = (nums[j], nums[i]);
            }

            // ���������� ��������� ������ �� ������� i
            Reverse(nums, i + 1, nums.Length - 1);
        }

        private static void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                (nums[start], nums[end]) = (nums[end], nums[start]);
                start++;
                end--;
            }
        }
        public static bool IsCorrectMove(string from, string to)
        {
            var fromLetter = from[0];
            var toLetter = to[0];
            var fromNumber = from[1];
            var toNumber = to[1];

            if (fromLetter == toLetter && fromNumber == toNumber) return false;
            if (fromLetter == toLetter || fromNumber == toNumber) return true;
            return Math.Abs(fromLetter - toLetter) == Math.Abs(fromNumber - toNumber);
        }

        public static int MiddleOf(int a, int b, int c)
        {
            if (a == b) return a;
            if (a == c) return a;
            if (b == c) return b;

            return a + b + c - Math.Max(Math.Max(a, b), Math.Max(a, c)) - Math.Min(Math.Min(a, b), Math.Min(a, c));
        }
    }

    public static class SolutionSortArrayByParity
    {
        public static int[] SortArrayByParity(int[] nums)
        {
            return nums.Where(x => x % 2 == 0).Concat(nums.Where(x => x % 2 != 0)).ToArray();
        }
    }

    public static class SolutionIntReverse
    {
        public static int IntReverse(int x)
        {
            try
            {
                var minus = string.Empty;
                if (x < 0)
                {
                    x = Math.Abs(x);
                    minus = "-";
                }
                return int.Parse(minus + new string(x.ToString().Reverse().ToArray()));
            }
            catch
            {
                return 0;
            }
        }
    }

    public static class SolutionMyAtoi
    {
        public static int MyAtoi(string s)
        {
            s = s.Trim();
            if (s.Length == 0) return 0;
            if (s[0] == '-' || s[0] == '+' || s.Length == 0)
                if (!char.IsDigit(s.SkipWhile(x => x == ' ').Skip(1).FirstOrDefault()))
                    return 0;

            var ss = new string(s.SkipWhile(x => x == '+').TakeWhile(x => char.IsDigit(x) || x == '-').ToArray());
            if (ss.Contains('-'))
            {
                ss = ss.FirstOrDefault() == '-'
                    ? "-" + new string(ss.Skip(1).TakeWhile(x => x != '-').ToArray())
                    : new string(ss.TakeWhile(x => x != '-').ToArray());
            }

            if (!int.TryParse(ss, out int res))
            {
                if (ss.Length == 0) return 0;
                if (ss.FirstOrDefault() == '-' && ss.Length == 1) return 0;
                return ss.FirstOrDefault() == '-' ? Int32.MinValue : Int32.MaxValue;
            }
            return res;
        }
    }

    public static class SolutionMaxArea
    {
        public static int MaxArea(int[] height)
        {
            var res = 0;
            var i = 0;
            var j = height.Length - 1;
            while (i < j)
            {
                var vol = (j - i) * Math.Min(height[i], height[j]);
                res = Math.Max(res, vol);
                if (height[i] > height[j])
                    --j;
                else
                    ++i;
            }
            return res;
        }
    }


    public static class SolutionIsMatch
    {
        static bool delOneSymbol;
        public static bool IsMatch(string s, string p)
        {
            var bases = s;
            var dot = '.';
            var star = '*';
            if (s == p) return true;
            if (!p.Any(x => x == dot || x == star) && p != s) return false;
            if (!p.Any(x => x != dot && x != star) && p.Any(x => x == star)) return true;

            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] == dot)
                {
                    if (i < p.Length - 1)
                    {
                        if (p[i + 1] == star)
                            s = RemoveEntry(s, s[0], true);
                    }
                    s = s.Substring(1);
                    if (s.Length == 0) return true;
                    continue;
                }

                if ((i != p.Length - 1) && (p[i] == dot || p[i] == star)) continue;

                if (i == p.Length - 1)
                {
                    if (p[i] == dot) return s.Length == 1;
                    if (p[i] == star) return s.All(x => x == s[0]);
                    if (bases.Last() != p[i]) return false;
                    if (delOneSymbol) return false;
                    s = RemoveEntry(s, p[i], false);
                    //if (s.Length == 0) return false;
                    continue;
                }

                if (p[i + 1] == star)
                {
                    s = RemoveEntry(s, p[i], true);
                    if (s.Length == 0 && i == p.Length - 2) return true;
                    i++;
                    if (i < p.Length - 1 && i > 0)
                    {
                        if (p[i + 1] == p[i - 1])
                            i++;
                    }
                    continue;
                }

                if (s.Length == 0) return false;
                s = RemoveEntry(s, p[i], false);
            }
            return s.Length == 0;
        }

        public static string RemoveEntry(string s, char entry, bool anyCount)
        {
            if (!anyCount)
            {
                if (s.Length == 0) return s;
                if (s[0] != entry) return s;
                s = s.Substring(1);
                if (s.Length == 0) delOneSymbol = true;
                return s;
            }

            return new string(s.SkipWhile(x => x == entry).ToArray());
        }
    }

    public static class SolutionClimbStairs
    {
        public static int ClimbStairs(int n)
        {
            var dp = new int[n + 1];

            dp[0] = 1;
            dp[1] = 2;

            for (int i = 2; i < n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n - 1];
        }
    }
}

public class Solution
{
    public bool WinnerOfGame(string colors)
    {
        var aliceCount = CountSubstr(colors, "AAA");
        var bobCount = CountSubstr(colors, "BBB");
        return (aliceCount > bobCount);
    }

    public int CountSubstr(string colors, string substr)
    {
        if (!colors.Contains(substr)) return 0;
        var count = 0;

        for (int i = 0; i < colors.Length - (substr.Length - 1); i++)
        {
            if (colors.Substring(i, substr.Length) == substr)
                count++;
        }

        return count;
    }

    public string Convert(string s, int numRows)
    {
        var i = 0;
        var goUp = true;
        var q = new Dictionary<int, List<char>>(numRows);

        for (int j = 0; j < numRows; j++)
        {
            q.Add(j, new List<char>());
        }

        foreach (var c in s)
        {
            q[i].Add(c);

            i = goUp ? i + 1 : i - 1;
            if (i == numRows - 1) goUp = false;
            if (i == 0) goUp = true;
        }

        var sb = new StringBuilder(s.Length);
        for (int j = 0; j < q.Count; j++)
        {
            foreach (var c in q[j])
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }

    public int NumIdenticalPairs(int[] nums)
    {
        var cnt = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j]) cnt++;
            }
        }
        return cnt;
    }


    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var res = new List<IList<string>>();
        if (strs.Length == 1)
        {
            res.Add(new List<string>() { strs[0] });
            return res;
        }
        var alreadyDoneStr = "_";

        var strsSorted = strs.Select(x => new string(x.OrderBy(c => c).ToArray())).ToList();

        for (int i = 0; i < strs.Length; i++)
        {
            if (strs[i] == alreadyDoneStr) continue;
            var newList = new List<string>() { strs[i] };
            if (i < strs.Length - 1)
            {
                for (int j = i + 1; j < strs.Length; j++)
                {
                    if (strs[j] == alreadyDoneStr) continue;
                    if (strsSorted[i] == strsSorted[j])
                    {
                        newList.Add(strs[j]);
                        strs[j] = alreadyDoneStr;
                    }
                }
            }

            strs[i] = alreadyDoneStr;
            res.Add(newList);
        }

        return res;
    }

    public int ThreeSumClosest(int[] nums, int target)
    {
        Array.Sort(nums);
        var res = 0;
        var min = int.MaxValue;

        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            var start = i + 1;
            var end = nums.Length - 1;
            while (start < end)
            {
                var sum = nums[i] + nums[start] + nums[end];
                if (target == sum) return target;

                var cur = Math.Abs(target - sum);
                if (cur < min)
                {
                    min = cur;
                    res = sum;
                }

                if (sum < target) start++;
                else end--;
            }
        }

        return res;
    }

    public class MyHashMap
    {
        readonly Dictionary<int, int> _map;
        public MyHashMap()
        {
            _map = new Dictionary<int, int>();
        }

        public void Put(int key, int value)
        {
            _map[key] = value;
        }

        public int Get(int key)
        {
            return _map.TryGetValue(key, out var value) ? value : -1;
        }

        public void Remove(int key)
        {
            _map.Remove(key);
        }
    }

    [SuppressMessage("ReSharper", "RedundantAssignment")]
    [SuppressMessage("ReSharper", "RedundantCast")]
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        Array.Sort(nums);
        var res = new Dictionary<string, IList<int>>();

        var ext1 = 0;               // external left index
        var ext2 = nums.Length - 1; // external right index
        var int1 = 1;               // internal left index
        var int2 = nums.Length - 2; // internal right index

        for (ext1 = 0; ext1 < nums.Length - 1; ext1++)
        {
            for (ext2 = nums.Length - 1; ext2 > 0; ext2--)
            {
                int1 = ext1 + 1;
                int2 = ext2 - 1;
                while (int1 < int2)
                {
                    var sum = (long)nums[ext1] + (long)nums[ext2] + (long)nums[int1] + (long)nums[int2];
                    if (sum == target)
                    {
                        var arr = new[] { nums[ext1], nums[int1], nums[int2], nums[ext2] };
                        var s = string.Join(' ', arr);
                        res.TryAdd(s, arr);
                    }

                    if (sum <= target) int1++;
                    else int2--;
                }
            }
        }

        return res.Values.ToList();
    }

    public string ReverseWords(string s)
    {
        var ss = s.Split(' ');
        var bb = ss.Select(x => new string(x.Reverse().ToArray())).ToArray();
        return string.Join(' ', bb);

        // ��� ���:
        //var sb = new StringBuilder(s.Length);
        //var ss = s.Split(' ');
        //foreach (var str in ss)
        //{
        //    var i = 0;
        //    while (i >= 0)
        //    {
        //        sb.Append(str[i]);
        //        i--;
        //    }
        //    sb.Append(' ');
        //}
        //return sb.ToString().Trim();
    }

    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var listNodes = new List<ListNode>();
        var curNode = head;
        listNodes.Add(curNode);
        while (curNode.next != null)
        {
            listNodes.Add(curNode.next);
            curNode = curNode.next;
        }

        listNodes.RemoveAt(listNodes.Count - n);

        for (int i = 0; i < listNodes.Count; i++)
        {
            if (i == listNodes.Count - 1) listNodes[i].next = null;
            else listNodes[i].next = listNodes[i + 1];
        }

        return listNodes.First();
    }

    public int Divide(int dividend, int divisor)
    {
        if (dividend == int.MinValue && divisor == -1) return int.MaxValue;
        if (divisor == 1) return dividend;
        if (divisor == 0) return 0;

        var longdivisor = Math.Abs((long)divisor);
        var longdividend = Math.Abs((long)dividend);

        var res = 0;
        if (longdivisor == longdividend) res = 1;
        else
        {
            while (longdivisor <= longdividend)
            {
                res++;
                longdividend -= longdivisor;
            }
        }

        return (divisor < 0 ^ dividend < 0) ? 0 - res : res;
    }

    public int IntegerBreak(int n)
    {
        if (n == 2) return 1;
        if (n == 3) return 2;
        var divider = 2;
        var res = 0;

        while (n / divider > 0)
        {
            var del = n / divider;
            var mod = n % divider;

            var arr = new int[del];
            Array.Fill(arr, divider);
            var cur = 1;

            if (del * mod >= del + mod)
                cur = mod;
            else
                arr[0] = arr[0] + mod;


            foreach (var item in arr)
                if (item > 0) cur *= item;

            res = Math.Max(res, cur);

            divider++;
        }

        return res;
    }

    public int[] SearchRange(int[] nums, int target)
    {
        //// �������� ����� O(n)
        //if (nums.Length == 0) return new int[2] { -1, -1 };
        //var i = 0;
        //var j = nums.Length - 1;
        //while ((nums[i] != target || nums[j] != target) && i < j)
        //{
        //    if (nums[i] != target) i++;
        //    if (nums[j] != target) j--;
        //}
        //if (nums[i] != target || nums[j] != target) return new int[2] { -1, -1 };
        //return new int[2] { i, j };

        // �������� ����� O(logn)
        // ������� ��� ���� :)

        return new int[2] { -1, 1 };
    }
}

#endregion
