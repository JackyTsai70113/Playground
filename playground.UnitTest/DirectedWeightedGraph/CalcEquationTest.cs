using playground.DirectedWeightedGraph;
using playground.UnitTest.Utils;

namespace playground.UnitTest.DirectedWeightedGraph;

public class DirectedWeightedGraphTest
{
    [Theory]
    [InlineData(new string[] { "a", "b", "b", "c" }, new double[] { 2.0, 3.0 }, new string[] { "a", "c", "b", "a", "a", "e", "a", "a", "x", "x" }, new double[] { 6.00000, 0.50000, -1.00000, 1.00000, -1.00000 })]
    public void CalcEquationTest(string[] array, double[] values, string[] array2, double[] expected)
    {
        //
        var equations = array.To2dArray(2);
        var queries = array2.To2dArray(2);
        //
        var actual = CalcEquationClass.CalcEquation(equations, values, queries);
        //
        Assert.Equal(expected, actual);
    }
}
