using playground._3300_3399;

namespace playground.UnitTest._3300_3399;

public class _3393_CountPathsWithXorValueTest
{
    [Theory]
    [InlineData("[[2, 1, 5], [7, 10, 0], [12, 6, 4]]", 11, 3)]
    [InlineData("[[1, 3, 3, 3], [0, 3, 3, 2], [3, 0, 1, 1]]", 2, 5)]
    public void CountPathsWithXorValue(string grid, int k, int expected)
    {
        var actual = _3393_CountPathsWithXorValue.CountPathsWithXorValue(grid.To2dArr(), k);
        Assert.Equal(expected, actual);
    }
}
