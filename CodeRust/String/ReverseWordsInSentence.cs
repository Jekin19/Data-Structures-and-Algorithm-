using System;
namespace CodeRust.String
{
    public class ReverseWordsInSentence
    {
        public static string ReverseWords(char[] sentence)
        {
            if (sentence == null || sentence.Length < 2) { return new string(sentence); }

            //Reverse entire sentence
            Reverse(sentence, 0, sentence.Length - 1);

            int start = 0;
            while(start < sentence.Length) {
                while(start < sentence.Length && sentence[start] == ' ' ){
                    start++;
                }
                int end = start;
                while(end < sentence.Length && sentence[end] != ' ') {
                    end++;
                }
                Reverse(sentence, start, end - 1);
                start = end;
            }
            return new string(sentence);
        }

       static void Reverse(char[] input, int start, int end) {
            while(start < end) {
                char temp = input[start];
                input[start] = input[end];
                input[end] = temp;
                start++;
                end--;
            }
        }
    }
}
