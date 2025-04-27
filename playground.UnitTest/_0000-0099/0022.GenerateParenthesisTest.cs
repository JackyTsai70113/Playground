namespace playground.UnitTest;

public class GenerateParenthesisTest0022
{
    [Theory]
    [InlineData(3, new string[] { "((()))", "(()())", "(())()", "()(())", "()()()" })]
    [InlineData(1, new string[] { "()" })]
    public void GenerateParenthesis(int n, IList<string> expected)
    {
        var actual = GenerateParenthesis0022.GenerateParenthesis(n);
        Assert.Equal(expected, actual);
    }
}
