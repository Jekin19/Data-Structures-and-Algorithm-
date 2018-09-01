
namespace CodeRust.String
{
    public class RemoveWhiteSpaces
    {
        public static string RemoveWhiteShape(char[] str)
        {
            if (str == null) { return new string(str); }

            int readIndex = 0; int writeIndex = 0;
            while(readIndex < str.Length) {
                if(str[readIndex] != ' ') {
                    str[writeIndex] = str[readIndex];
                    writeIndex++;
                }
                readIndex++;
            }
            return new string(str, 0, writeIndex);

        }
    }
}
