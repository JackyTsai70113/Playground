namespace playground.UnitTest;

public class MaxScoreTest3290
{
    [Theory]
    [InlineData(new int[] { 3, 2, 5, 6 }, new int[] { 2, -6, 4, -5, -3, 2, -7 }, 26)]
    [InlineData(new int[] { -1, 4, 5, -2 }, new int[] { -5, -1, -3, -2, -4 }, -1)]
    public void MaxScore(int[] a, int[] b, long expected)
    {
        var actual = MaxScore3290.MaxScore(a, b);
        Assert.Equal(expected, actual);
    }
}
