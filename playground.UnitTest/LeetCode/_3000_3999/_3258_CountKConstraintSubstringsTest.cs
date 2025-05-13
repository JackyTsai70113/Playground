using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3258_CountKConstraintSubstringsTest
{
    [Theory]
    [InlineData("10101", 1, 12)]
    [InlineData("1010101", 2, 25)]
    [InlineData("11111", 1, 15)]
    public void CountKConstraintSubstrings(string s, int k, int expected)
    {
        var actual = _3258_CountKConstraintSubstrings.CountKConstraintSubstrings(s, k);
        Assert.Equal(expected, actual);
    }
}
