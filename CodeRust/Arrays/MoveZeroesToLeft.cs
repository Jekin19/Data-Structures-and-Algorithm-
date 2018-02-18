namespace CodeRust.Arrays
{   
    // https://www.careercup.com/question?id=5731103635668992
    public class MoveZeroesToLeft
    {
       public static int[] ShiftZeros(int[] input)
        {
            int currentPointer = input.Length-1;
            int nonZeroPointer = currentPointer;
            while(currentPointer >= 0 && nonZeroPointer >=0)
            {
                if (input[currentPointer] == 0)
                {
                    for (int i = nonZeroPointer-1; i >= 0; i--)
                    {
                        if (input[i] != 0)
                        {
                            input[currentPointer] = input[i];
                            input[i] = 0;
                            nonZeroPointer = i;
                            break;
                        }
                    }
                }
                else
                {
                    nonZeroPointer--;
                }
                currentPointer--;

            }

            return input;
        }

    }
}
