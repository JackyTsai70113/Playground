using playground._1300_1399;

namespace playground.UnitTest_1300_1399;

public class _1391_HasValidPathTest
{
    [Theory]
    [InlineData("[[2,4,3],[6,5,2]]", true)]
    [InlineData("[[1,2,1],[1,2,1]]", false)]
    [InlineData("[[1,1,2]]", false)]
    [InlineData("[[1,1,3],[1,2,2]]", true)]
    [InlineData("[[4,3,3],[6,5,2]]", false)]
    public void HasValidPath(string A, bool expected)
    {
        var actual = new _1391_HasValidPath_cs().HasValidPath(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
