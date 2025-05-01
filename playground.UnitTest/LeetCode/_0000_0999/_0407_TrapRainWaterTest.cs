using playground.LeetCode._0000_0999;

using playground._0400_0499;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0407_TrapRainWaterTest
{
    [Theory]
    [InlineData("[[1,4],[3,2]]", 0)]
    [InlineData("[[1,4,1],[3,2,1],[3,2,1]]", 0)]
    [InlineData("[[1,4,3,1,3,2],[3,2,1,3,2,4],[2,3,3,2,3,1]]", 4)]
    [InlineData("[[3,3,3,3,3],[3,2,2,2,3],[3,2,1,2,3],[3,2,2,2,3],[3,3,3,3,3]]", 10)]
    public void TrapRainWater(string map, int expected)
    {
        var actual = _0407_TrapRainWater.TrapRainWater(map.To2dArr());
        Assert.Equal(expected, actual);
    }
}
