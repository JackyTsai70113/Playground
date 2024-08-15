namespace playground.UnitTest;

public class FindMaxValueOfEquationTest1499
{
    [Theory]
    [InlineData("[[1,3],[2,0],[5,10],[6,-10]]", 1, 4)]
    [InlineData("[[0,0],[3,0],[9,2]]", 3, 3)]
    public void FindMaxValueOfEquation(string points, int k, int expected)
    {
        var actual = FindMaxValueOfEquation1499.FindMaxValueOfEquation(points.To2dArr(), k);
        Assert.Equal(expected, actual);
    }
}
