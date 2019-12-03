using System;
using System.Collections.Generic;
using System.Text;

namespace SwordFingerO
{
    public class Task5
    {
        public string ReplaceSpace(string str)
        {
            // write code here
            if (str == null)
                return null;
            var strByte = str.ToCharArray();
            var newLength = strByte.Length;
            foreach (var t in strByte)
            {
                if (t == ' ')
                {
                    newLength += 2;
                }
            }
            
            var newByte = new char[newLength];
            var p1 = strByte.Length - 1;
            var p2 = newLength - 1;
            while (p1>=0 || p1 != p2)
            {
                if (strByte[p1] == ' ')
                {
                    newByte[p2--] = '0';
                    newByte[p2--] = '2';
                    newByte[p2--] = '%';
                    p1--;
                }
                else
                {
                    newByte[p2--] = strByte[p1--];
                }
            }
            
            return new string(newByte);
        }
    }
}
