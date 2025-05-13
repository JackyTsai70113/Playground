namespace playground.UnitTest.LeetCode._1000_1999;

public class _1334_FindTheCityTest
{
    [Theory]
    [InlineData(4, "[[0,1,3],[1,2,1],[1,3,4],[2,3,1]]", 4, 3)]
    [InlineData(5, "[[0,1,2],[0,4,8],[1,2,3],[1,4,2],[2,3,1],[3,4,1]]", 2, 0)]
    public void FindTheCity(int n, string edges, int distanceThreshold, int expected)
    {
        var actual = _1334_FindTheCity.FindTheCity(n, edges.To2dArr(), distanceThreshold);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(4, "[[0,1,3],[1,2,1],[1,3,4],[2,3,1]]", 4, 3)]
    [InlineData(5, "[[0,1,2],[0,4,8],[1,2,3],[1,4,2],[2,3,1],[3,4,1]]", 2, 0)]
    public void FindTheCity2(int n, string edges, int distanceThreshold, int expected)
    {
        var actual = _1334_FindTheCity.FindTheCity2(n, edges.To2dArr(), distanceThreshold);
        Assert.Equal(expected, actual);
    }
}
