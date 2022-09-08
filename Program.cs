﻿#region Battleship Kata
using hw;

int[,] field = new int[10,10]
                     {{1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
                      {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                      {1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
                      {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                      {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                      {0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};

var res = BattleshipField.ValidateBattlefield(field);

System.Console.WriteLine(res);
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