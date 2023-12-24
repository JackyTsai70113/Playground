namespace playground.UnitTest;

public class MaximumLengthTest2982
{
    [Theory]
    [InlineData("aaaa", 2)]
    [InlineData("abcdef", -1)]
    [InlineData("abcaba", 1)]
    public void MaximumLength(string s, int expected)
    {
        var actual = MaximumLength2982.MaximumLength(s);
        Assert.Equal(expected, actual);
    }
}
