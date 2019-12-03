using SwordFingerO.Geek;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTest.GeekTest
{
    public class SelfStackTest
    {
        [Fact]
        public void Test()
        {
            var stack = new SelfStack(1);
            stack.Push(3);
            var x = stack.Pop();
            Assert.Equal(3, x);
            stack.Push(2);
            stack.Push(5);
            x = stack.Pop();
            Assert.Equal(5, x);
            x = stack.Pop();
            Assert.Equal(2, x);
        }
    }
}
