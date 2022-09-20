namespace hw
{
    public class ToSmallest
    {
        public static long[] Smallest(long n)
        {
            var res = new List<long[]>();
            var s = n.ToString();

            for (var i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                    res.Add(new long[] {long.Parse(s.Remove(i, 1).Insert(j, s.Substring(i, 1))), i, j});
            }

            return res.OrderBy(x => x[0]).ThenBy(x => x[1]).First();
        }
    }
}