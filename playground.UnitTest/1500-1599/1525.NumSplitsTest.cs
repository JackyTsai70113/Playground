namespace playground.UnitTest;

public class NumSplitsTest1525
{
    [Theory]
    [InlineData("aacaba", 2)]
    [InlineData("abcd", 1)]
    [InlineData("asdfghjkl", 0)]
    public void NumSplits(string s, int expected)
    {
        var actual = NumSplits1525.NumSplits(s);
        Assert.Equal(expected, actual);
    }
}
