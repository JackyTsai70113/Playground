using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0399_CalcEquationTest
{
    [Theory]
    [InlineData("[[\"a\",\"b\"],[\"b\",\"c\"]]",
        new double[] { 2.0, 3.0 }, "[[\"a\",\"c\"],[\"b\",\"a\"],[\"a\",\"e\"],[\"a\",\"a\"],[\"x\",\"x\"]]",
        new double[] { 6.00000, 0.50000, -1.00000, 1.00000, -1.00000 })]
    [InlineData("[[\"x1\",\"x2\"],[\"x2\",\"x3\"],[\"x3\",\"x4\"],[\"x4\",\"x5\"]]",
        new double[] { 3.0, 4.0, 5.0, 6.0 },
    "[[\"x1\",\"x5\"],[\"x5\",\"x2\"],[\"x2\",\"x4\"],[\"x2\",\"x2\"],[\"x2\",\"x9\"],[\"x9\",\"x9\"]]",
        new double[] { 360.00000, 0.0083333333333333332, 20.00000, 1.00000, -1.00000, -1.00000 })]
    public void CalcEquationTest(string equations, double[] values, string queries, double[] expected)
    {
        var actual = _0399_CalcEquation.CalcEquation(equations.To2dArr<string>(), values, queries.To2dArr<string>());
        Assert.Equal(expected, actual);
    }
}
