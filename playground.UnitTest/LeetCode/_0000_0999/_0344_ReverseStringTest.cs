using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0344_ReverseStringTest
{
    [Theory]
    [InlineData(new char[] { 'h', 'e', 'l', 'l', 'o' }, new char[] { 'o', 'l', 'l', 'e', 'h' })]
    [InlineData(new char[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new char[] { 'h', 'a', 'n', 'n', 'a', 'H' })]
    public void ReverseString(char[] s, char[] expected)
    {
        _0344_ReverseString.ReverseString(s);
        Assert.Equal(expected, s);
    }
}
