namespace playground.UnitTest;

public class SolutionTest0519
{
    [Theory]
    [InlineData(new string[] { "Solution", "flip", "flip", "flip", "reset", "flip" }, "[[3, 1], [], [], [], [], []]")]
    public void Solution(string[] funcs, string valStr)
    {
        var vals = valStr.To2dArr();
        int m = vals[0][0], n = vals[0][1];
        Solution0519 obj = new(vals[0][0], vals[0][1]);
        for (int i = 1; i < funcs.Length; ++i)
        {
            switch (funcs[i])
            {
                case "flip":
                    var actual = obj.Flip();
                    Assert.True(0 <= actual[0] && actual[0] < m);
                    Assert.True(0 <= actual[1] && actual[1] < n);
                    break;
                case "reset":
                    obj.Reset();
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
