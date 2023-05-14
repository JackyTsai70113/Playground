using playground.DirectedWeightedGraph;
using playground.UnitTest.Utils;

namespace playground.UnitTest.DirectedWeightedGraph;

public class DirectedWeightedGraphTest
{
    [Theory]
    [InlineData("[[a,b], [b,c]]", "[2.0, 3.0]", "[[a,c], [b,a], [a,e], [a,a], [x,x]]", "[6.00000, 0.50000, -1.00000, 1.00000, -1.00000]")]
    [InlineData("[[x1,x2],[x2,x3],[x3,x4],[x4,x5]]", "[3.0,4.0,5.0,6.0]", "[[x1,x5],[x5,x2],[x2,x4],[x2,x2],[x2,x9],[x9,x9]]","[360.00000,0.0083333333333333332,20.00000,1.00000,-1.00000,-1.00000]")]
    public void CalcEquationTest(string equationsStr, string valuesStr, string queriesStr, string expectedStr)
    {
        var equations = equationsStr.To2dArr<string>();
        var values = valuesStr.ToArr<double>();
        var queries = queriesStr.To2dArr<string>();
        var expected = expectedStr.ToArr<double>();

        var actual = CalcEquationClass.CalcEquation(equations, values, queries);
        
        Assert.Equal(expected, actual);
    }
}
