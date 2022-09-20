namespace hw
{
    public class BuildSquareKata
    {
        public static string GenerateShape(int n)
        {            
            var res = string.Empty;
            for (int i = 0; i < n; i++)
            {                
                if(res != string.Empty)
                    res += "\n";
                for (int j = 0; j < n; j++)
                    res += '+';
            }

            return res;
        }
    }
}