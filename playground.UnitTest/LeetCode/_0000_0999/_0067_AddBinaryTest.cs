using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0067_AddBinaryTest
{
    [Theory]
    [InlineData("1", "11", "100")]
    [InlineData("11", "1", "100")]
    [InlineData("1010", "1011", "10101")]
    public void AddBinary(string a, string b, string expected)
    {
        var actual = _0067_AddBinary.AddBinary(a, b);
        Assert.Equal(expected, actual);
    }
}
