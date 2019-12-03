using System;

namespace SwordFingerO
{
    public class Task3
    {
        //find duplicate number
        public bool Duplicate(int[] numbers, int[] duplication)
        {
            // write code here
            var length = numbers.Length;
            if (length == 0)
                return false;

            for (int i = 0; i < length; i++)
            {
                while (numbers[i] != i)
                {
                    if (numbers[i] == numbers[numbers[i]])
                    {
                        duplication[0] = numbers[i];
                        return true;
                    }
                    var temp = numbers[numbers[i]];
                    numbers[numbers[i]] = numbers[i];
                    numbers[i] = temp;
                }
            }
            return false;
        }

        //find duplicate number without modify
        public int GetDuplicate(int[] numbers)
        {
            return 0;
        }
    }
}
