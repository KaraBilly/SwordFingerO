using System;
using System.Collections.Generic;
using System.Text;
using SwordFingerO.Geek;
using Xunit;

namespace XUnitTest.GeekTest
{
    public class SortTest
    {
        private Sort _sort = new Sort();
        [Fact]
        public void BubbleSortTest()
        {
            var nums = new int[] {3, 2, 5, 12, 6, 34, 7, 9};
            _sort.BubbleSort(nums);
        }
        [Fact]
        public void InsertedSortTest()
        {
            var nums = new int[] { 2, 3, 5, 12, 6, 34, 7, 9 };
            _sort.InsertedSort(nums);
        }
    }
}
