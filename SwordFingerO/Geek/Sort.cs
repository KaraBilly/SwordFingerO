using System;
using System.Collections.Generic;
using System.Text;

namespace SwordFingerO.Geek
{
    public class Sort
    {
        /// <summary>
        ///  Space Complexity O(1)     原地排序算法
        ///  Time Complexity  O(n^2)
        ///     稳定的排序算法
        /// </summary>
        /// <param name="nums"></param>
        public void BubbleSort(int[] nums)
        {
            if(nums == null || nums.Length == 0)    return;
            var len = nums.Length;
            for (var i = 0; i < len; i++)
            {
                var flag = false;
                for (var j = 0; j < len - i - 1; j++)
                {
                    if (nums[j] <= nums[j + 1]) continue;
                    var tmp = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = tmp;
                    flag = true;
                }
                if(!flag)   break;
            }
        }

        /// <summary>
        ///  Space Complexity O(1)      原地排序算法
        ///  Time Complexity O(n^2)
        ///     稳定的排序算法
        /// </summary>
        /// <param name="nums"></param>
        public void InsertedSort(int[] nums)
        {
            if (nums == null || nums.Length == 0) return;
            var len = nums.Length;
            for (var i = 1; i < len; i++)
            {
                var value = nums[i];
                var j = i - 1;
                for (; j >= 0; j--)
                {
                    if (value < nums[j])
                    {
                        nums[j + 1] = nums[j];
                    }
                    else
                    {
                        break;
                    }
                }

                nums[j+1] = value;
            }
        }

        public void SelectSort(int[] nums)
        {

        }

        /// <summary>
        ///     插入排序的优化版本
        /// https://zh.wikipedia.org/wiki/%E5%B8%8C%E5%B0%94%E6%8E%92%E5%BA%8F
        /// </summary>
        /// <param name="nums"></param>
        public void HillSort(int[] nums)
        {

        }
    }
}
