using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1190_ReverseParenthesesTest
{
    [Theory]
    [InlineData("(abcd)", "dcba")]
    [InlineData("(u(love)i)", "iloveu")]
    [InlineData("(ed(et(oc))el)", "leetcode")]
    public void ReverseParentheses(string s, string expected)
    {
        var actual = _1190_ReverseParentheses.ReverseParentheses(s);
        Assert.Equal(expected, actual);
    }
}
