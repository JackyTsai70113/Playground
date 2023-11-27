namespace playground.UnitTest;

public class ColorTheArrayTest_2672
{
    [Theory]
    [InlineData(4, "[[0,2],[1,2],[3,1],[1,1],[2,1]]", "[0, 1, 1, 0, 2]")]
    [InlineData(3, "[[0,2],[1,2],[2,2]]", "[0, 1, 2]")]
    [InlineData(4, "[[0,2],[1,2],[2,1],[1,1]]", "[0, 1, 1, 1]")]
    [InlineData(4, "[[0,2],[1,1],[2,1],[1,2]]", "[0, 0, 1, 1]")]
    [InlineData(3, "[[2,2],[1,2],[0,2]]", "[0, 1, 2]")]
    [InlineData(3, "[[0,2],[1,3],[2,4]]", "[0, 0, 0]")]
    [InlineData(3, "[[2,4],[1,3],[0,2]]", "[0, 0, 0]")]
    [InlineData(1, "[[0,100000]]", "[0]")]
    public void ColorTheArray(int n, string queriesStr, string expected)
    {
        var queries = queriesStr.To2dArr();
        var actual = ColorTheArray_2672.ColorTheArray(n, queries);
        Assert.True(Enumerable.SequenceEqual(expected.ToArr(), actual));
    }
}
