using System.Text.RegularExpressions;

namespace hw
{
    public static class BattleshipField
    {
        public static bool ValidateBattlefield(int[,] field)
        {
            // Check diagonal
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    if (field[i, j] == 1 && (field[i + 1, j + 1] == 1 ||
                                             field[i - 1, j - 1] == 1 ||
                                             field[i + 1, j - 1] == 1 ||
                                             field[i - 1, j + 1] == 1
                                            ))
                    {
                        Console.WriteLine("Diagonal fail");
                        return false;
                    }
                }
            }

            // Count submarines
            var submarineCount = 0;
            int[,] sea = new int[12, 12];

            // Fill sea
            for (int i = 1; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    sea[i + 1, j + 1] = field[i, j];
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (sea[i, j] == 1 && (sea[i + 1, j] == 0 &&
                                           sea[i - 1, j] == 0 &&
                                           sea[i, j - 1] == 0 &&
                                           sea[i, j + 1] == 0
                                          ))
                    {
                        submarineCount++;
                    }
                }
            }

            var battleshipCount = 0;
            var cruiserCount = 0;
            var destroyerCount = 0;

            for (int i = 0; i < 10; i++)
            {
                var s = "0";
                for (int j = 0; j < 10; j++)
                {
                    s = s + field[i, j].ToString();
                }
                s = s + "0";
                battleshipCount = battleshipCount + Regex.Matches(s, "011110").Count;
                cruiserCount = cruiserCount + Regex.Matches(s, "01110").Count;
                destroyerCount = destroyerCount + Regex.Matches(s, "0110").Count;
            }

            for (int j = 0; j < 10; j++)
            {
                var s = "0";
                for (int i = 0; i < 10; i++)
                {
                    s = s + field[i, j].ToString();
                }
                s = s + "0";
                battleshipCount = battleshipCount + Regex.Matches(s, "011110").Count;
                cruiserCount = cruiserCount + Regex.Matches(s, "01110").Count;
                destroyerCount = destroyerCount + Regex.Matches(s, "0110").Count;
            }

            Console.WriteLine($"Battleship count = {battleshipCount}");
            Console.WriteLine($"Cruiser count = {cruiserCount}");
            Console.WriteLine($"Destroyer count = {destroyerCount}");
            Console.WriteLine($"Submarine count = {submarineCount}");            

            return (battleshipCount == 1 && cruiserCount == 2 && destroyerCount == 3 && submarineCount == 4);
        }
    }
}