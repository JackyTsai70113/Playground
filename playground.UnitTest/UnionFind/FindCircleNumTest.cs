using playground.UnionFinds;

namespace playground.UnitTest.UnionFinds;

public class FindCircleNumTest
{
    [Theory]
    [InlineData("[[1,1,0],[1,1,0],[0,0,1]]", 2)]
    public void MaxNumEdgesToRemove(string A, int expected)
    {
        var actual = FindCircleNumClass.FindCircleNum(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
