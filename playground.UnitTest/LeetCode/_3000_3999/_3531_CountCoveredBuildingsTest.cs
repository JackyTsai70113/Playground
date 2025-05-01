using playground._3500_3599;

namespace playground.UnitTest._3500_3599;

public class _3531_CountCoveredBuildingsTest
{
    [Theory]
    [InlineData(3, "[[1,2],[2,2],[3,2],[2,1],[2,3]]", 1)]
    [InlineData(3, "[[1,1],[1,2],[2,1],[2,2]]", 0)]
    [InlineData(5, "[[1,3],[3,2],[3,3],[3,5],[5,3]]", 1)]
    public void CountCoveredBuildings(int n, string B, int expected)
    {
        var actual = _3531_CountCoveredBuildings.CountCoveredBuildings(n, B.To2dArr());
        Assert.Equal(expected, actual);
    }
}
