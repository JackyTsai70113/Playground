namespace playground.UnitTest;

public class _1567_GetMaxLenTest
{
    [Theory]
    [InlineData(new int[] { 1, -2, -3, 4 }, 4)]
    [InlineData(new int[] { 0, 1, -2, -3, -4 }, 3)]
    [InlineData(new int[] { -1, -2, -3, 0, 1 }, 2)]
    public void GetMaxLen(int[] A, int expected)
    {
        var actual = _1567_GetMaxLen.GetMaxLen(A);
        Assert.Equal(expected, actual);
    }
}
