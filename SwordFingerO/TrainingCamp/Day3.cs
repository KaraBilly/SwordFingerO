using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwordFingerO.TrainingCamp
{
    public class Day3
    {
        /// <summary>
        ///    可以通过当前位是否为9判断是否需要进位，但是不够通用
        ///     需要注意如何去做两个数组的拼接后转成Array
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public int[] PlusOne(int[] digits)
        {
            if (digits == null || digits.Length == 0) return digits;
            var len = digits.Length;
            var plus = true;
            
            for (var i = len - 1; i >= 0; i--)
            {
                if (!plus) break;
                var temp = digits[i] + 1;
                plus = temp == 10;
                digits[i] = plus ? 0 : temp;
            }

            if (!plus) return digits;
            var res = new[] { 1 };
            res[0] = 1;
            res = res.Concat(digits).ToArray();
            return res;
        }
    }
}
