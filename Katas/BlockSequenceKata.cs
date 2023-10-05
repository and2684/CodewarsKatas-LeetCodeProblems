using System.Text;

namespace hw
{
    public class BlockSeq
    {
        public static int solve(long n)
        {
            int i = 1;
            int blockNumber = 0;
            var sb = new StringBuilder();

            while (n > 0)
            {
                n = n - i;
                blockNumber++;
                i++;
                i = i + i.ToString().Length - 1;
            }

            // Console.WriteLine($"Block number = {blockNumber}");
            // Console.WriteLine($"Block number = {--i}");
            // Console.WriteLine($"Remainder of the division = {n}");

            for (i = 1; i <= blockNumber; i++)
            {
                sb = sb.Append(i);
            }

            var s = sb.ToString();

            // System.Console.WriteLine($"Block = {s}");

            // System.Console.WriteLine(s.Substring(s.Length - 1 + (int)n).First().ToString());

            return int.Parse(s.Substring(s.Length - 1 + (int)n).First().ToString());
        }
    }
}