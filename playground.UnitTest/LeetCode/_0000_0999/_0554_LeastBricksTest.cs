using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0554_LeastBricksTest
{
    [Theory]
    [InlineData("[[1,2,2,1],[3,1,2],[1,3,2],[2,4],[3,1,2],[1,3,1,1]]", 2)]
    [InlineData("[[1],[1],[1]]", 3)]
    public void LeastBricks(string wall, int expected)
    {
        var actual = _0554_LeastBricks.LeastBricks(wall.To2dArr());
        Assert.Equal(expected, actual);
    }
}
