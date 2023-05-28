using playground.Greedy;

namespace playground.UnitTest.Greedy;

public class MinSwapsCouplesTest
{
    [Theory]
    [InlineData(new int[] { 0, 2, 1, 3 }, 1)]
    [InlineData(new int[] { 3, 2, 0, 1 }, 0)]
    [InlineData(new int[] { 2, 0, 5, 4, 3, 1 }, 1)]
    [InlineData(new int[] { 5, 4, 2, 6, 3, 1, 0, 7 }, 2)]
    public void MinSwapsCouples(int[] row, int expected)
    {
        var actual = MinSwapsCouplesClass.MinSwapsCouples(row);
        Assert.Equal(expected, actual);
    }
}
