using System;
namespace CodeRust.MathAndStats
{
    public class NumberValid
    {
        private enum State {
            Start,
            Decimal,
            Integer,
            Unknown
        }

        public static bool IsNumberValid(string input) {
            if (string.IsNullOrEmpty(input)) {
                return false;
            }
            int i = 0;
            if(input[i] == '+' || input[i] == '-') {
                i++;
            }
            if (i >= input.Length) {
                return false;
            }
            var currentState = State.Start;
            while(i < input.Length) {
                currentState = GetNextState(currentState, input[i]);
                if(currentState == State.Unknown) {
                    return false;
                }
                i++;
            }
            return true;
        }

        private static State GetNextState(State currentState, char input)
        {
            switch (currentState)
            {
                case State.Start:
                case State.Integer:
                    if(input == '.') {
                        return State.Decimal;
                    }
                    if(input >= '0' && input <= '9') {
                        return State.Integer;
                    }
                    return State.Unknown;
                case State.Decimal:
                     if (input >= '0' && input <= '9')
                    {
                        return State.Decimal;
                    }
                    return State.Unknown;
                default: return State.Unknown;
            }
           
        }
    }
    
}
