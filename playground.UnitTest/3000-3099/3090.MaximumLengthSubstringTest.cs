namespace playground.UnitTest;

public class MaximumLengthSubstringTest3090
{
    [Theory]
    [InlineData("bcbbbcba", 4)]
    [InlineData("aaaa", 2)]
    public void MaximumLengthSubstring(string s, int expected)
    {
        var actual = MaximumLengthSubstring3090.MaximumLengthSubstring(s);
        Assert.Equal(expected, actual);
    }
}
