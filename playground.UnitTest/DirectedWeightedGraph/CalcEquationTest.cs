using playground.DirectedWeightedGraph;
using playground.UnitTest.Utils;

namespace playground.UnitTest.DirectedWeightedGraph;

public class DirectedWeightedGraphTest
{
    [Theory]
    [InlineData("[[a,b], [b,c]]", "[2.0, 3.0]", "[[a,c], [b,a], [a,e], [a,a], [x,x]]", "[6.00000, 0.50000, -1.00000, 1.00000, -1.00000]")]
    public void CalcEquationTest(string equationsStr, string valuesStr, string queriesStr, string expectedStr)
    {
        //
        var equations = equationsStr.To2dArr<string>();
        var values = valuesStr.ToArr<double>();
        var queries = queriesStr.To2dArr<string>();
        //
        var actual = CalcEquationClass.CalcEquation(equations, values, queries);
        //
        Assert.Equal(expectedStr.ToArr<double>(), actual);
    }
}
