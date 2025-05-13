using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3261_CountKConstraintSubstringsTest
{
    [Theory]
    [InlineData("0001111", 2, "[[0,6]]", new long[] { 26 })]
    [InlineData("010101", 1, "[[0,5],[1,4],[2,3]]", new long[] { 15, 9, 3 })]
    public void CountKConstraintSubstrings(string s, int k, string qs, long[] expected)
    {
        var actual = _3261_CountKConstraintSubstrings.CountKConstraintSubstrings(s, k, qs.To2dArr());
        Assert.Equal(expected, actual);
    }
}
