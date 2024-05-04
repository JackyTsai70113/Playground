namespace playground.UnitTest;

public class FindTheCityTest1334
{
    [Theory]
    [InlineData(4, "[[0,1,3],[1,2,1],[1,3,4],[2,3,1]]", 4, 3)]
    [InlineData(5, "[[0,1,2],[0,4,8],[1,2,3],[1,4,2],[2,3,1],[3,4,1]]", 2, 0)]
    public void FindTheCity(int n, string edges, int distanceThreshold, int expected)
    {
        var actual = FindTheCity1334.FindTheCity(n, edges.To2dArr(), distanceThreshold);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(4, "[[0,1,3],[1,2,1],[1,3,4],[2,3,1]]", 4, 3)]
    [InlineData(5, "[[0,1,2],[0,4,8],[1,2,3],[1,4,2],[2,3,1],[3,4,1]]", 2, 0)]
    public void FindTheCity2(int n, string edges, int distanceThreshold, int expected)
    {
        var actual = FindTheCity1334.FindTheCity2(n, edges.To2dArr(), distanceThreshold);
        Assert.Equal(expected, actual);
    }
}
