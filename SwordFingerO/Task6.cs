using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwordFingerO
{
    public class Task6
    {
        public ListNode ReverseList(ListNode head)
        {
            var current = head;
            ListNode prev = null;
            while (current != null)
            {
                var temp = current.next;
                current.next = prev;

                prev = current;
                current = temp;
            }

            return prev;
        }

        //public ListNode ResListNodeByStack(ListNode head)
        //{
        //    var stack = new Stack<int>();
        //    var node = head;
        //    while (node != null)
        //    {
        //        stack.Push(head.val);
        //        node = node.next;
        //    }

        //    node = new ListNode(0);
        //    while (stack.Any())
        //    {
        //        node.val = stack.Pop();
        //        node.next = 
        //    }
        //}


        public bool BackspaceCompare(string S, string T)
        {
            var sstack = PopValues(S);
            var tstack = PopValues(T);
            while (sstack.Any() && tstack.Any())
            {
                if (sstack.Pop() != tstack.Pop()) return false;
            }
            return true;
        }
        private Stack<char> PopValues(string str)
        {
            var stack = new Stack<char>();
            foreach (var x in str)
            {
                if (x == '#')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(x);
                }
            }
            return stack;
        }


    }

    public class ListNode
    {
         public int val;
         public ListNode next;
         public ListNode(int x) { val = x; }
    }
}
