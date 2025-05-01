using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2981_MaximumLengthTest
{
    [Theory]
    [InlineData("aaaa", 2)]
    [InlineData("aaaaaaffff", 4)]
    [InlineData("abcdef", -1)]
    [InlineData("abcaba", 1)]
    public void MaximumLength(string s, int expected)
    {
        var actual = _2981_MaximumLength.MaximumLength(s);
        Assert.Equal(expected, actual);
    }
}
