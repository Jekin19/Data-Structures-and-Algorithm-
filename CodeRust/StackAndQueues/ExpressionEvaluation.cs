using System;
using System.Collections.Generic;

namespace CodeRust.StackAndQueues
{
    public class ExpressionEvaluation
    {
        public static double EvaluateExpression(string input) {

            var postFixExpression = CreatePostFixExpression(input);
            return CalculateSum(postFixExpression);
   
        }

        private static double CalculateSum(Queue<char> input) {

            Stack<double> stack = new Stack<double>();
            while (input.Count > 0) {
                var current = input.Dequeue();
                if(IsOperand(current)) {
                    double.TryParse(current.ToString(), out double output);
                    stack.Push(output);
                }
                if(IsOperator(current)) {
                    var input1 = stack.Pop();
                    var input2 = stack.Pop();
                    stack.Push(PerformOperation(input1, input2, current));
                }
            }

            return stack.Pop();
        }

        private static double PerformOperation(double input1, double input2, char operand) {
            switch(operand) {
                case '+': return input2 + input1;
                case '-': return input2 - input1;
                case '/': return input2 / input1;
                case '*': return input2 * input1;
            }
            throw new Exception();
        }

        private static Queue<char> CreatePostFixExpression(string input) {
            Queue<char> result = new Queue<char>();
            Stack<char> operandStack = new Stack<char>();
            for (int i = 0; i < input.Length; i++) {
               
                if(IsOperand(input[i])){
                    result.Enqueue(input[i]);
                }
                if (IsOperator(input[i]))
                {
                    while(operandStack.Count > 0 && IsHigherPrecedence(operandStack.Peek(), input[i])) {
                        result.Enqueue(operandStack.Pop());
                    }
                    operandStack.Push(input[i]);
                }


            }

            while (operandStack.Count > 0) {
                result.Enqueue(operandStack.Pop());
            }

            return result;
        }

        private static bool IsHigherPrecedence(char input1, char input2) {
            if(input1 == '+' || input1 == '-') {
                return input2 == '-' || input2 == '+';
            }
            if (input1 == '*' || input1 == '/')
            {
                return input2 == '-' || input2 == '+' || input2 == '/' || input2 == '*';
            }
            return false;
        
        }

        private static bool IsOperator(char input) {
            return input == '+' || input == '-' || input == '*' || input == '/';
        }

        private static bool IsOperand(char input)
        {
            return double.TryParse(input.ToString(), out double output);
        }
    }
}
