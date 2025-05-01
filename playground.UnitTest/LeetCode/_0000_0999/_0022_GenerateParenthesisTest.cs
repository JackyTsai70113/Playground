using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0022_GenerateParenthesisTest
{
    [Theory]
    [InlineData(3, new string[] { "((()))", "(()())", "(())()", "()(())", "()()()" })]
    [InlineData(1, new string[] { "()" })]
    public void GenerateParenthesis(int n, IList<string> expected)
    {
        var actual = _0022_GenerateParenthesis.GenerateParenthesis(n);
        Assert.Equal(expected, actual);
    }
}
