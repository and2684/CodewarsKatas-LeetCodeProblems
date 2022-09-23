using System.Text;

namespace hw
{
    public class SnailSolution
    {
        public static int[] Snail(int[][] array)
        {
            if (array.Length == 0) return new int[0];
            var firstColumn = 0;
            var lastColumn = array.GetLength(0) - 1;
            var firstRow = 0;
            var lastRow = lastColumn;
            var res = new List<int>(array.Length * array.Length); 

            while (res.Count != res.Capacity)
            {
                for (int i = firstColumn; i <= lastColumn; i++)
                    res.Add(array[firstRow][i]);
                firstRow++;

                for (int i = firstRow; i <= lastRow; i++)
                    res.Add(array[i][lastColumn]);
                lastColumn--;

                for (int i = lastColumn; i >= firstColumn; i--)
                    res.Add(array[lastRow][i]);
                lastRow--;

                for (int i = lastRow; i >= firstRow; i--)
                    res.Add(array[i][firstColumn]);
                firstColumn++;                             
            }

            return res.ToArray();

            // var res = new StringBuilder();
            // var firstColumn = 0;
            // var lastColumn = array.GetLength(0) - 1;
            // var firstRow = 0;
            // var lastRow = lastColumn;

            // while (firstRow != lastRow || firstColumn != lastColumn)
            // {
            //     for (int i = firstColumn; i <= lastColumn; i++)
            //         res.Append($"{array[firstRow][i]} ");
            //     firstRow++;

            //     for (int i = firstRow; i <= lastRow; i++)
            //         res.Append($"{array[i][lastColumn]} ");
            //     lastColumn--;

            //     for (int i = lastColumn; i >= firstColumn; i--)
            //         res.Append($"{array[lastRow][i]} ");
            //     lastRow--;

            //     for (int i = lastRow; i >= firstRow; i--)
            //         res.Append($"{array[i][firstColumn]} ");
            //     firstColumn++;                             
            // }

            // res.Append($"{array[firstRow][firstColumn] }");

            // return res.ToString().Split(' ').ToArray();
        }
    }
}