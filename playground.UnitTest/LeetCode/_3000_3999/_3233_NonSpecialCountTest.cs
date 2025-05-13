namespace playground.UnitTest.LeetCode._3000_3999;

public class _3233_NonSpecialCountTest
{
    [Theory]
    [InlineData(5, 7, 3)]
    [InlineData(4, 16, 11)]
    public void NonSpecialCount(int l, int r, int expected)
    {
        var actual = _3233_NonSpecialCount.NonSpecialCount(l, r);
        Assert.Equal(expected, actual);
    }
}
