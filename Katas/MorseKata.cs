using System.Text;

namespace MorseCata
{
    public class MorseCodeDecoder
    {
        public static string Decode(string morseCode)
        {
            var sb = new StringBuilder();
            var morseWordList = morseCode.Split("   ");
            foreach (var word in morseWordList)
            {
                var morseWord = word.Split(" ");
                foreach (var c in morseWord)
                {
                    //sb.Append(MorseCode.Get(c)); // этот словарик давался в кате, тут не нужен
                }
            }
            sb.Append(" ");
            return sb.ToString().Trim();
        }
    }
}