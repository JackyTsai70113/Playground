namespace playground.UnitTest;

public class _1898_MaximumRemovalsTest
{
    [Theory]
    [InlineData("abcacb", "ab", "[3, 1, 0]", 2)]
    [InlineData("abcbddddd", "abcd", "[3, 2, 1, 4, 5, 6]", 1)]
    [InlineData("abcab", "abc", "[0, 1, 2, 3, 4]", 0)]
    public void MaximumRemovals(string s, string p, string rs, int expected)
    {
        var actual = _1898_MaximumRemovals.MaximumRemovals(s, p, rs.ToArr());
        Assert.Equal(expected, actual);
    }
}
