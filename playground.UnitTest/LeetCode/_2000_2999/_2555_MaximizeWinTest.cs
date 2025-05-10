using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2555_MaximizeWinTest
{
    [Theory]
    [InlineData(new[] { 1, 1, 2, 2, 3, 3, 5 }, 3, 7)]
    [InlineData(new[] { 1, 1, 2, 2, 3, 3, 5 }, 2, 7)]
    [InlineData(new[] { 1, 2, 3, 4 }, 0, 2)]
    [InlineData(new[] { 1, 2, 3, 4 }, 1, 4)]
    [InlineData(new[] { 1, 2, 3, 4 }, 2, 4)]
    [InlineData(new[] { 1, 2, 3, 4 }, 3, 4)]
    [InlineData(new[] { 1, 2, 3, 4 }, 4, 4)]
    [InlineData(new[] { 1, 2, 3, 4 }, 5, 4)]
    public void MaximizeWinTest(int[] A, int k, int expected)
    {
        var result = _2555_MaximizeWin.MaximizeWin(A, k);
        Assert.Equal(expected, result);
    }
}
