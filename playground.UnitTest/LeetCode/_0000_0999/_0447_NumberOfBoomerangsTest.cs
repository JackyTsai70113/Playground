using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0447_NumberOfBoomerangsTest
{
    [Theory]
    [InlineData("[[0,0],[1,0],[2,0]]", 2)]
    [InlineData("[[1,1],[2,2],[3,3]]", 2)]
    [InlineData("[[1,1]]", 0)]
    public void NumberOfBoomerangs(string points, int expected)
    {
        var actual = _0447_NumberOfBoomerangs.NumberOfBoomerangs(points.To2dArr());
        Assert.Equal(expected, actual);
    }
}
