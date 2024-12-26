using playground._2800_2899;

namespace playground.UnitTest._2800_2899;

public class _2872_MaxKDivisibleComponentsTest
{
    [Theory]
    [InlineData(5, "[[0,2],[1,2],[1,3],[2,4]]", new int[] { 1, 8, 1, 4, 4 }, 6, 2)]
    [InlineData(7, "[[0,1],[0,2],[1,3],[1,4],[2,5],[2,6]]", new int[] { 3, 0, 6, 1, 5, 2, 1 }, 3, 3)]
    [InlineData(1, "[]", new int[] { 0 }, 1, 1)]
    [InlineData(3, "[[1,2],[2,0]]", new int[] { 0, 2, 2 }, 4, 2)]
    public void MaxKDivisibleComponents(int n, string edges, int[] values, int k, int expected)
    {
        var actual = _2872_MaxKDivisibleComponents.MaxKDivisibleComponents(n, edges.To2dArr(), values, k);
        Assert.Equal(expected, actual);
    }
}
