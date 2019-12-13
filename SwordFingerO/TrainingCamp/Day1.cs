using System;
using System.Collections.Generic;
using System.Text;

namespace SwordFingerO.TrainingCamp
{
    public class Day1
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            var slow = 0;
            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[slow])
                {
                    nums[++slow] = nums[i];
                }
            }

            return ++slow;
        }
    }
}
