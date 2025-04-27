using playground._3400_3499;

namespace playground.UnitTest._3400_3499;

public class _3419_MinMaxWeightTest
{
    [Theory]
    [InlineData(5, "[[1,0,1],[2,0,2],[3,0,1],[4,3,1],[2,1,1]]", 2, 1)]
    [InlineData(5, "[[0,1,1],[0,2,2],[0,3,1],[0,4,1],[1,2,1],[1,4,1]]", 1, -1)]
    [InlineData(5, "[[1,2,1],[1,3,3],[1,4,5],[2,3,2],[3,4,2],[4,0,1]]", 1, 2)]
    [InlineData(5, "[[1,2,1],[1,3,3],[1,4,5],[2,3,2],[4,0,1]]", 1, -1)]
    public void MinMaxWeight(int n, string edges, int threshold, int expected)
    {
        var actual = _3419_MinMaxWeight.MinMaxWeight(n, edges.To2dArr(), threshold);
        Assert.Equal(expected, actual);
    }
}
