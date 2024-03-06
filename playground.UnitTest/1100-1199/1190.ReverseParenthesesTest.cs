namespace playground.UnitTest;

public class ReverseParenthesesTest1190
{
    [Theory]
    [InlineData("(abcd)", "dcba")]
    [InlineData("(u(love)i)", "iloveu")]
    [InlineData("(ed(et(oc))el)", "leetcode")]
    public void ReverseParentheses(string s, string expected)
    {
        var actual = ReverseParentheses1190.ReverseParentheses(s);
        Assert.Equal(expected, actual);
    }
}
