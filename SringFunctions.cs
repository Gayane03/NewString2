using System.Text;

namespace NewString2
{
    internal class SringFunctions
    {
        public string MyReverse(string txt)
        {
            var charTxt = txt.ToCharArray();
            StringBuilder sb = new();

            for (int i = txt.Length - 1; i >= 0; i--)
                sb.Append(charTxt[i]);
            return sb.ToString();
        }
        public string[] ReturnWords(string? sentence)
        {
            string[] def= { " Null "};
            if (!String.IsNullOrEmpty(sentence) || !String.IsNullOrWhiteSpace(sentence))
            {
                string[] words = sentence.Split(' ');
                return words;   
            }
            return def;
        }

    }
}
