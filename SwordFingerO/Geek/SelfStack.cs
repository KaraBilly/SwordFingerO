using System;
using System.Collections.Generic;
using System.Text;

namespace SwordFingerO.Geek
{
    /// <summary>
    /// 数组实现栈
    /// </summary>
    public class SelfStack
    {
        private int[] stack;
        private int length;
        private int count;
        public SelfStack(int n)
        {
            stack = new int[10];
            count = 0;
            length = n;
        }
        public bool Push(int num)
        {
            if (count == length) 
            {
                var tempStack = new int[count * 2];
                for(var i = 0; i < count; i++)
                {
                    tempStack[i] = stack[i];
                }
                stack = tempStack;
            }
            stack[count] = num;
            count++;
            return true;
        }
        public int? Pop()
        {
            if (count == 0) return null;
            return stack[--count];
        }
    }
}
