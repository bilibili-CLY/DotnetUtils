using DotnetUtils.字符串;

namespace UnitTest.字符串
{
    public class StringHelperTest
    {
        [Fact]
        public void SplitStrToList_Test()
        {
            var result = StringHelper.SplitStrToList("A,B,C,D");
            Assert.Equal(4, result.Count);
        }
    }
}
