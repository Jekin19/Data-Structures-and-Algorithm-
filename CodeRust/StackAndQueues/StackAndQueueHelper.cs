using System;
using CodeRust.Helpers;

namespace CodeRust.StackAndQueues
{
    public class StackAndQueueHelper
    {
        public static void StackAndQueueProblems()
        {
            Console.WriteLine("Stack using queue...");
            var stackUsingQueue = new StackUsingQueue<int>();
            Console.WriteLine("Push 1");
            stackUsingQueue.Push(1);
            Console.WriteLine("Push 2");
            stackUsingQueue.Push(2);
            Console.WriteLine("Count " + stackUsingQueue.Count);
            Console.WriteLine("Pop " + stackUsingQueue.Pop());
            Console.WriteLine("Count " + stackUsingQueue.Count);
            Console.WriteLine("Push 3");
            stackUsingQueue.Push(3);
            Console.WriteLine("Pop " + stackUsingQueue.Pop());
            Console.WriteLine("Clear ");
            stackUsingQueue.Clear();
            Console.WriteLine("Count " + stackUsingQueue.Count);


            Console.WriteLine("Queue using stack...");
            var queueUsingStack = new QueueUsingStack<int>();
            Console.WriteLine("Enqueue 1");
            queueUsingStack.Enqueue(1);
            Console.WriteLine("Enqueue 2");
            queueUsingStack.Enqueue(2);
            Console.WriteLine("Count " + queueUsingStack.Count);
            Console.WriteLine("Dequeue " + queueUsingStack.Dequeue());
            Console.WriteLine("Count " + queueUsingStack.Count);
            Console.WriteLine("Enqueue 3");
            queueUsingStack.Enqueue(3);
            Console.WriteLine("Dequeue " + queueUsingStack.Dequeue());
            Console.WriteLine("Clear ");
            queueUsingStack.Clear();
            Console.WriteLine("Count " + queueUsingStack.Count);

            Console.WriteLine("Evaluate Expression ");
            var input = "3+6*5-1/2";
            Console.WriteLine("Input: " + input);
            Console.WriteLine(ExpressionEvaluation.EvaluateExpression(input));

            Console.WriteLine("Word Ladder 2");
            var wordLadderInput = "start: hit; end: cog; dict: hot, dot, dog, lot, log";
            Console.WriteLine("Input: " + wordLadderInput);
            var output = WordLadder.GetAllMinWordLadders("hit", "cog", new System.Collections.Generic.HashSet<string> { "hot","dot","dog","lot","log" });
            Console.WriteLine(PrintHelpers.GetInputOuputs(output, "Output"));
                             
        }
    }
}
