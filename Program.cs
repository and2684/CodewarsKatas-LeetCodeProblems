using Tests;
#region Snail Kata
// using hw;

// int[][] array = new int [][]
// {
//     new []{1, 1, 1, 1, 1, 1, 1},
//     new []{2, 2, 2, 2, 2, 2, 2},
//     new []{3, 3, 3, 3, 3, 3, 3},
//     new []{4, 4, 4, 4, 4, 4, 4},
//     new []{5, 5, 5, 5, 5, 5, 5},
//     new []{6, 6, 6, 6, 6, 6, 6},    
//     new []{7, 7, 7, 7, 7, 7, 7}
// };
// var res = SnailSolution.Snail(array);

// foreach (var item in res)
// {
//     System.Console.WriteLine(item);
// }
#endregion

#region BuildSquare Kata
// using hw;

// System.Console.WriteLine(BuildSquareKata.GenerateShape(3));
#endregion

#region ToSmall Kata
// using hw;

// var s = ToSmallest.Smallest(285365);
// foreach (var item in s)
// {
//      System.Console.WriteLine(item);
// }
#endregion

#region Battleship Kata
// using hw;

// int[,] field = new int[10,10]
//                      {{1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
//                       {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
//                       {1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
//                       {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//                       {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
//                       {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
//                       {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
//                       {0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
//                       {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
//                       {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};

// var res = BattleshipField.ValidateBattlefield(field);

// System.Console.WriteLine(res);
#endregion

#region Block sequence Kata
// using hw;

// System.Console.WriteLine($"RESULT = {BlockSeq.solve(2100)}");
#endregion

#region Extension Kata
// using Extension;

// List<string> nameList = new List<string>() { "Sarah", "John", "Miko", "Tara", "Ali", "Sasi", "Arya", "David" };
// List<PersonTest> peopleList = new List<PersonTest>();
// for (int i = 0; i < 5; i++)
// {
//     string name = nameList[i];
//     PersonTest person = new PersonTest() { Name = name };
//     peopleList.Add(person);
// }
// List<object> objectList = peopleList.Cast<object>().ToList();
// System.Console.WriteLine(objectList.LeaderName());

// List<int> intList = new List<int>() { 15, 45, 85, 69, 52 };
// List<object> objectList2 = intList.Cast<object>().ToList();
// System.Console.WriteLine(objectList2.LeaderName());



// public class PersonTest
// {
//     public string Name { get; set; } = string.Empty;
// }
#endregion

#region LeetCode

//var b = SolutionValidParentheses.IsValid("()[]{}");
//System.Console.WriteLine(b);

//System.Console.WriteLine(SolutionPow.MyPow(34.00515, -3));

//System.Console.WriteLine(SolutionIsPalindrome.IsPalindrome(121));

//Console.WriteLine(SolutionSearchMatrix.SearchMatrix([new int[] { 1, 3, 5, 7 }, new int[] { 10, 11, 16, 20 }, new int[] { 23, 30, 34, 60 }], 3));
//Console.WriteLine(SolutionSearchMatrix.SearchMatrix([new int[] { 1, 3, 5, 7 }, new int[] { 10, 11, 16, 20 }, new int[] { 23, 30, 34, 50 }], 30));
//Console.WriteLine(SolutionSearchMatrix.SearchMatrix([new int[] { 1, 1 }, new int[] { 2, 2 }], 0));

//Console.WriteLine(SolutionThreeSum.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 }));

//Console.WriteLine(SolutionRemoveDuplicates.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));

//System.Console.WriteLine(SolutionValidPalindrome.IsPalindrome("A man, a plan, a canal: Panama"));

//System.Console.WriteLine(SolutionLongestCommonPrefix.LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));

//Console.WriteLine(SolutionRemoveElement.RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2));

//Console.WriteLine(SolutionCanPlaceFlowers.CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 1));
//Console.WriteLine(SolutionCanPlaceFlowers.CanPlaceFlowers(new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 1 }, 3));

//Console.WriteLine(SolutionRepeatedSubstringPattern.RepeatedSubstringPattern("abac"));
//Console.WriteLine(SolutionRepeatedSubstringPattern.RepeatedSubstringPattern("abab"));

//PisosComparerQ.PisosComaparing();

//SolutionRotate.Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3);

//Console.WriteLine(SolutionLongestPalindrome.LongestPalindrome("babad"));
//Console.WriteLine(SolutionLongestPalindrome.LongestPalindrome("cbbd"));

//Console.WriteLine(SolutionLongestConsecutive.LongestConsecutive(new int[] { 100, 4, 200, 1, 3, 2 }));

//Console.WriteLine(SolutionCanJump.CanJump(new int[] { 2, 3, 1, 1, 4 }));
//Console.WriteLine(SolutionCanJump.CanJump(new int[] { 3, 2, 1, 0, 4 }));
//Console.WriteLine(SolutionCanJump.CanJump(new int[] { 3, 0, 8, 2, 0, 0, 1 }));

//Console.WriteLine(SolutionMaxSubArray.MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));

//var res = SolutionProductExceptSelf.ProductExceptSelf(new int[] { 1, 2, 3, 4 });
//var res = SolutionProductExceptSelf.ProductExceptSelf(new int[] { 3, 4, 5, 6, 7 });
//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine(SolutionIsInterleave.IsInterleave("aa", "ab", "aaba"));
//SolutionMoveZeroes.MoveZeroes(new int[] { 0, 1, 0, 3, 12 });
//Console.WriteLine(SolutionStrStr.StrStr("a", "a"));

//Console.WriteLine(SolutionPlusOne.PlusOne(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }));

//Console.WriteLine(SolutionConvertToTitle.ConvertToTitle(701));
//Console.WriteLine(SolutionConvertToTitle.ConvertToTitle(28));
//Console.WriteLine(SolutionConvertToTitle.ConvertToTitle(2147483647));

//var list = SolutionLetterCombinations.LetterCombinations("23");
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}

//var arr = new int[] { 6, 7, 5, 3, 5, 6, 2, 9, 1, 2, 7, 0, 9 };
//SolutionNextPermutation.NextPermutation(arr);

//Console.WriteLine(SolutionIntReverse.IntReverse(123));
//Console.WriteLine(SolutionIntReverse.IntReverse(-123));
//Console.WriteLine(SolutionIntReverse.IntReverse(120));
//Console.WriteLine(SolutionIntReverse.IntReverse(1534236469));

//Console.WriteLine(SolutionMyAtoi.MyAtoi("42"));
//Console.WriteLine(SolutionMyAtoi.MyAtoi("        -42"));
//Console.WriteLine(SolutionMyAtoi.MyAtoi("4193 with words"));
//Console.WriteLine(SolutionMyAtoi.MyAtoi("00000-42a1234"));

var solution = new Solution();
//Console.WriteLine(solution.GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" }));
//Console.WriteLine(solution.ThreeSumClosest(new int[] { -43, 57, -71, 47, 3, 30, -85, 6, 60, -59, 0, -46, -40, -73, 53, 68, -82, -54, 88, 73, 20, -89, -22, 39, 55, -26, 95, -87, -57, -86, 28, -37, 43, -27, -24, -88, -35, 82, -3, 39, -85, -46, 37, 45, -24, 35, -49, -27, -96, 89, 87, -62, 85, -44, 64, 78, 14, 59, -55, -10, 0, 98, 50, -75, 11, 97, -72, 85, -68, -76, 44, -12, 76, 76, 8, -75, -64, -57, 29, -24, 27, -3, -45, -87, 48, 10, -13, 17, 94, -85, 11, -42, -98, 89, 97, -66, 66, 88, -89, 90, -68, -62, -21, 2, 37, -15, -13, -24, -23, 3, -58, -9, -71, 0, 37, -28, 22, 52, -34, 24, -8, -20, 29, -98, 55, 4, 36, -3, -9, 98, -26, 17, 82, 23, 56, 54, 53, 51, -50, 0, -15, -50, 84, -90, 90, 72, -46, -96, -56, -76, -32, -8, -69, -32, -41, -56, 69, -40, -25, -44, 49, -62, 36, -55, 41, 36, -60, 90, 37, 13, 87, 66, -40, 40, -35, -11, 31, -45, -62, 92, 96, 8, -4, -50, 87, -17, -64, 95, -89, 68, -51, -40, -85, 15, 50, -15, 0, -67, -55, 45, 11, -80, -45, -10, -8, 90, -23, -41, 80, 19, 29, 7 }, 255));
//solution.FourSum(new[] { 1000000000, 1000000000, 1000000000, 1000000000 }, -294967296);
//Console.WriteLine(solution.Divide(-2147483648, 2));
Console.WriteLine(solution.IntegerBreak(2));
//Console.WriteLine(solution.IntegerBreak(10));

Console.ReadKey();

#endregion
