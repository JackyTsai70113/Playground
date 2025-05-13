namespace playground.UnitTest.LeetCode._1000_1999;

public class _1525_NumSplitsTest
{
    [Theory]
    [InlineData("aacaba", 2)]
    [InlineData("abcd", 1)]
    [InlineData("asdfghjkl", 0)]
    public void NumSplits(string s, int expected)
    {
        var actual = _1525_NumSplits.NumSplits(s);
        Assert.Equal(expected, actual);
    }
}
