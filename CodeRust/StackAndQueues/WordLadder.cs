using System;
using System.Collections.Generic;

namespace CodeRust.StackAndQueues
{
    public class WordLadder
    {
        public class WordNode
        {
            public string word;
            public int numSteps;
            public List<string> words = new List<string>();

            public WordNode(string word, int numSteps, List<string> words)
            {
                this.word = word;
                this.numSteps = numSteps;
                this.words = words;
            }
        }

        public static List<List<string>> GetAllMinWordLadders(string beginWord, string endWord, HashSet<string> wordDict)
        {
            Queue<WordNode> queue = new Queue<WordNode>();
            queue.Enqueue(new WordNode(beginWord, 1, new List<string>()));
            int min = Int32.MaxValue;
            List<List<string>> result = new List<List<string>>();
             wordDict.Add(endWord);

            HashSet<string> visited = new HashSet<string>();
            HashSet<string> unvisited = new HashSet<string>(wordDict);
            int preNumSteps = 0;

            while (queue.Count > 0)
            {
                WordNode top = queue.Dequeue();
                string word = top.word;
                int currNumSteps = top.numSteps;

                if (word.Equals(endWord))
                {
                    if(top.numSteps <= min) {
                        result.Add(top.words);
                    }
                    continue;
                }

                if (preNumSteps < currNumSteps)
                {
                    foreach (var vis in visited)
                    {
                        unvisited.Remove(vis);
                    }
                }
                preNumSteps = currNumSteps;

                char[] arr = word.ToCharArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    for (char c = 'a'; c <= 'z'; c++)
                    {
                        char temp = arr[i];
                        if (arr[i] != c)
                        {
                            arr[i] = c;
                        }

                        string newWord = new string(arr);
                        if (unvisited.Contains(newWord))
                        {
                            var wordtemp =  new List<string> (top.words);
                            wordtemp.Add(word);
                            queue.Enqueue(new WordNode(newWord, top.numSteps + 1, wordtemp));
                            visited.Add(newWord);

                        }

                        arr[i] = temp;
                    }
                }
            }

            return result;
        }
    }
}
