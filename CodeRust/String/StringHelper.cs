using System;
using System.Collections.Generic;

namespace CodeRust.String
{
    public class StringHelper
    {
        public static void StringProblems() {
            //Console.WriteLine("Reverse words in a sentence");
            //var reverseWordsInput = "|   Hello  Wo rd  |";
            //Console.WriteLine("Input: " + reverseWordsInput);
            //var reverseWordsOutput = ReverseWordsInSentence.ReverseWords(reverseWordsInput.ToCharArray());
            //Console.Write("Output:" + reverseWordsOutput);
            //Console.WriteLine("");

            //Console.WriteLine("Reverse words in a sentence ");
            //var reverseWordsInput2 = "  Quick brown fox jumped over the lazy dog   ";
            //Console.WriteLine("Input: " + reverseWordsInput2);
            //var reverseWordsOutput2 = ReverseWordsInSentence.ReverseWords(reverseWordsInput2.ToCharArray());
            //Console.Write("Output:" + reverseWordsOutput2);
            //Console.WriteLine("");


            //Console.WriteLine("Remove duplicates");
            //var removeDuplicatesInput = "ABCDDE";
            //Console.WriteLine("Input: " + removeDuplicatesInput);
            //var removeDuplicatesOutput = RemoveDuplicates.RemoveDuplicate(removeDuplicatesInput.ToCharArray());
            //Console.Write("Output:" + removeDuplicatesOutput);
            //Console.WriteLine("");

            //Console.WriteLine("Remove duplicates 2");
            //var removeDuplicatesInput2 = "   Quick brown fox jumped   over lazy   dog           ";
            //Console.WriteLine("Input: " + removeDuplicatesInput2);
            //var removeDuplicatesOutput2 = RemoveDuplicates.RemoveDuplicate(removeDuplicatesInput2.ToCharArray());
            //Console.Write("Output:" + removeDuplicatesOutput2);
            //Console.WriteLine("");

            //Console.WriteLine("Remove white space");
            //var removeWhiteSpaceInput = " Hello World ";
            //Console.WriteLine("Input: " + removeWhiteSpaceInput);
            //var removeWhiteSpaceOutput = RemoveDuplicates.RemoveDuplicate(removeWhiteSpaceInput.ToCharArray());
            //Console.Write("Output:" + removeWhiteSpaceOutput);
            //Console.WriteLine("");

            //Console.WriteLine("Remove white space 2");
            //var removeWhiteSpaceInput2 = "   Quick brown fox jumped   over lazy   dog           ";
            //Console.WriteLine("Input: " + removeWhiteSpaceInput2);
            //var removeWhiteSpaceOutput2 = RemoveDuplicates.RemoveDuplicate(removeWhiteSpaceInput2.ToCharArray());
            //Console.Write("Output:" + removeWhiteSpaceOutput2);
            //Console.WriteLine("");

            //Console.WriteLine("String Segmentation");
            //var stringSegmentationInput = "goalspecial";
            //var dict = new HashSet<string> { "go", "goal", "goals", "special" };
            //Console.WriteLine("Input: " + stringSegmentationInput);
            //Console.WriteLine("Dictionary Input: " + "go" + "goal" +  "goals" + "special");
            //var stringSegmentationOutput = StringSegmentation.CanSegmentString(stringSegmentationInput, dict);
            //Console.Write("Output:" + stringSegmentationOutput);
            //Console.WriteLine("");

            //Console.WriteLine("String Segmentation 2");
            //var stringSegmentationInput2 = "goalspecial";
            //var dict2 = new HashSet<string> { "go", "goa", "goals", "special" };
            //Console.WriteLine("Input: " + stringSegmentationInput2);
            //Console.WriteLine("Dictionary Input: " + "go" + "goa" + "goals" + "special");
            //var stringSegmentationOutput2 = StringSegmentation.CanSegmentString(stringSegmentationInput2, dict2);
            //Console.Write("Output:" + stringSegmentationOutput2);
            //Console.WriteLine("");

            Console.WriteLine("Word Break");
            var stringSegmentationInput = "goalspecial";
            var dict = new HashSet<string> { "go", "goal", "goals", "s", "pecial" };
            Console.WriteLine("Input: " + stringSegmentationInput);
            Console.WriteLine("Dictionary Input: " + "go" + "goal" + "goals" + "s" + "pecial");
            var stringSegmentationOutput = StringSegmentation.WordBreak(stringSegmentationInput, dict);
            Console.Write("Output:" + stringSegmentationOutput);
            Console.WriteLine("");


            //Console.WriteLine("Find All Palindrom Substringd");
            //var palindromInput = "aabbbaa";
            //Console.WriteLine("Input: " + palindromInput);
            //var palindromOutput = AllPalindromSubstrings.FindAllPalindromSubstring(palindromInput);
            //Console.Write("Output: " + palindromOutput);
            //Console.WriteLine("");

            //Console.WriteLine("Find All Palindrom Substringd");
            //var palindromInput2 = "abc";
            //Console.WriteLine("Input: " + palindromInput2);
            //var palindromOutput2 = AllPalindromSubstrings.FindAllPalindromSubstring(palindromInput2);
            //Console.Write("Output: " + palindromOutput2);
            //Console.WriteLine("");

        }
    }
}
