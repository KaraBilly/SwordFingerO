using System;
using System.Collections.Generic;
using System.Text;

namespace SwordFingerO.Geek
{
    public class SelfQueue
    {
        private int length;
        private int head;
        private int tail;
        private int[] queue;
        public SelfQueue(int len)
        {
            length = len;
            head = 0;
            tail = 0;
            queue = new int[len];
        }
        public bool Enqueue(int val)
        {
            if (tail == length)
            {
                if (head == 0) return false;
                //tail处于空位置上，所以是<
                for(int i = head; i < tail; i++)
                {
                    queue[head - i] = queue[head];
                }
                head = 0;
                tail -= head;
            }
            queue[tail++] = val;
            return true;
        }
        public int? Dequeue()
        {
            if (head == tail) return null;
            return queue[head++];
        }
    }
}
