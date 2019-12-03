using SwordFingerO;
using Xunit;

namespace XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var t = new Task6();
            var s = t.BackspaceCompare("bxj##tw","bxj###tw");
        }
    }
}
