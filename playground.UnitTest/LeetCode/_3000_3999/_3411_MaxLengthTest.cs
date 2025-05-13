using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3411_MaxLengthTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 1, 2, 1, 1, 1 }, 5)]
    [InlineData(new int[] { 2, 3, 4, 5, 6 }, 3)]
    [InlineData(new int[] { 1, 2, 3, 1, 4, 5, 1 }, 5)]
    [InlineData(new int[] { 2, 6 }, 2)]
    [InlineData(new int[] { 2, 2, 8 }, 2)]
    public void MinStartingIndex(int[] A, long expected)
    {
        var actual = _3411_MaxLength.MaxLength(A);
        Assert.Equal(expected, actual);
    }
}
