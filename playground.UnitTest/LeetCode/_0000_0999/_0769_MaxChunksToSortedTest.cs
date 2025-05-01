using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0769_MaxChunksToSortedTest
{
    [Theory]
    [InlineData(new int[] { 4, 3, 2, 1, 0 }, 1)]
    [InlineData(new int[] { 1, 0, 2, 3, 4 }, 4)]
    [InlineData(new int[] { 0, 2, 1 }, 2)]
    [InlineData(new int[] { 2, 0, 1 }, 1)]
    [InlineData(new int[] { 1, 2, 0, 3 }, 2)]
    [InlineData(new int[] { 0, 4, 2, 3, 1 }, 2)]
    public void MaxChunksToSorted(int[] A, int expected)
    {
        var actual = _0769_MaxChunksToSorted.MaxChunksToSorted(A);
        Assert.Equal(expected, actual);
    }
}
