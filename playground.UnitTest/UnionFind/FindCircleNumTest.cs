using playground.UnionFinds;
using playground.UnitTest.Utils;

namespace playground.UnitTest.UnionFind;

public class FindCircleNumTest
{
    [Theory]
    [InlineData("[[1,1,0],[1,1,0],[0,0,1]]", 2)]
    public void MaxNumEdgesToRemove(string str, int expected)
    {
        var arr = str.To2dArr<int>();
        var actual = FindCircleNumClass.FindCircleNum(arr);
        Assert.Equal(expected, actual);
    }
}
