namespace playground.UnitTest.LeetCode._3000_3999;

public class _3090_MaximumLengthSubstringTest
{
    [Theory]
    [InlineData("bcbbbcba", 4)]
    [InlineData("aaaa", 2)]
    public void MaximumLengthSubstring(string s, int expected)
    {
        var actual = _3090_MaximumLengthSubstring.MaximumLengthSubstring(s);
        Assert.Equal(expected, actual);
    }
}
