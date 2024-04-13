namespace playground.UnitTest;

public class MaxChunksToSortedTest0769
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
        var actual = MaxChunksToSorted0769.MaxChunksToSorted(A);
        Assert.Equal(expected, actual);
    }
}
