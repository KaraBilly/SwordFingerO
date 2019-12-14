using System;
using System.Collections.Generic;
using System.Text;

namespace SwordFingerO.TrainingCamp
{
    public class Day2
    {
        public void Rotate(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0)
                return;
            var len = nums.Length;
            var rp = k % len;   //rotate point
            Reserve(nums, 0, len - 1);
            Reserve(nums, 0, rp-1);
            Reserve(nums, rp, len - 1);
        }

        private void Reserve(int[] nums, int start, int end)
        {
            while(start < end)
            {
                var temp = nums[start];
                nums[start++] = nums[end];
                nums[end--] = temp;
            }
            //throw new NotImplementedException();
        }
    }
}
