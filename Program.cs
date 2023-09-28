using hw;
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
Console.WriteLine(SolutionMyAtoi.MyAtoi("00000-42a1234"));

Console.ReadKey();

#endregion
