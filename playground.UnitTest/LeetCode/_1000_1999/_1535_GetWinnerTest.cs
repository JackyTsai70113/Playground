using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1535_GetWinnerTest
{
    [Theory]
    [InlineData(new int[] { 2, 1, 3, 5, 4, 6, 7 }, 2, 5)]
    [InlineData(new int[] { 3, 2, 1 }, 10, 3)]
    public void GetWinner(int[] arr, int k, int expected)
    {
        var actual = _1535_GetWinner.GetWinner(arr, k);
        Assert.Equal(expected, actual);
    }
}
