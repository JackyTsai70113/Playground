namespace playground.UnitTest;

public class SolutionTest0478
{
    [Theory]
    [InlineData(new string[] { "Solution", "randPoint", "randPoint", "randPoint" }, "[[1.0, 0.0, 0.0], [], [], []]")]
    public void Solution(string[] functions, string valStr)
    {
        var vals = valStr.To2dArr<double>();
        var (radius, x_center, y_center) = (vals[0][0], vals[0][1], vals[0][1]);
        Solution0478 obj = new(radius, x_center, y_center);
        for (int i = 1; i < functions.Length; ++i)
        {
            switch (functions[i])
            {
                case "randPoint":
                    var actual = obj.RandPoint();
                    var xDiff = Math.Abs(actual[0] - x_center);
                    var yDiff = Math.Abs(actual[1] - y_center);
                    Assert.True(xDiff * xDiff + yDiff * yDiff <= radius * radius, $"{xDiff * xDiff} {yDiff * yDiff} {radius * radius}");
                    break;
                default:
                    break;
            }
        }
    }
}
