namespace playground.UnitTest;

public class MaximumLengthTest2981
{
    [Theory]
    [InlineData("aaaa", 2)]
    [InlineData("aaaaaaffff", 4)]
    [InlineData("abcdef", -1)]
    [InlineData("abcaba", 1)]
    public void MaximumLength(string s, int expected)
    {
        var actual = MaximumLength2981.MaximumLength(s);
        Assert.Equal(expected, actual);
    }
}
