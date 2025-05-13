using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3461_HasSameDigitsTest
{
    [Theory]
    [InlineData("3902", true)]
    [InlineData("34789", false)]
    public void SeparateSquares(string s, bool expected)
    {
        var actual = _3461_HasSameDigits.HasSameDigits(s);
        Assert.Equal(expected, actual);
    }
}
