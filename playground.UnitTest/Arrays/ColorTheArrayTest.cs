using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class ColorTheArrayTest
{
    [Theory]
    [InlineData(4, "[[0,2],[1,2],[3,1],[1,1],[2,1]]", new int[] { 0, 1, 1, 0, 2 })]
    [InlineData(3, "[[0,2],[1,2],[2,2]]", new int[] { 0, 1, 2 })]
    [InlineData(4, "[[0,2],[1,2],[2,1],[1,1]]", new int[] { 0, 1, 1, 1 })]
    [InlineData(4, "[[0,2],[1,1],[2,1],[1,2]]", new int[] { 0, 0, 1, 1 })]
    [InlineData(3, "[[2,2],[1,2],[0,2]]", new int[] { 0, 1, 2 })]
    [InlineData(3, "[[0,2],[1,3],[2,4]]", new int[] { 0, 0, 0 })]
    [InlineData(3, "[[2,4],[1,3],[0,2]]", new int[] { 0, 0, 0 })]
    [InlineData(1, "[[0,100000]]", new int[] { 0 })]
    public void ColorTheArray(int n, string queriesStr, int[] expected)
    {
        var queries = queriesStr.To2dArr();
        var actual = ColorTheArrayClass.ColorTheArray(n, queries);
        Assert.Equal(expected, actual);
    }
}
