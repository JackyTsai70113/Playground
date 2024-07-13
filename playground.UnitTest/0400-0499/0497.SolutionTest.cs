namespace playground.UnitTest;

public class SolutionTest0497
{
    [Theory]
    [InlineData(new string[] { "Solution", "pick", "pick", "pick", "pick", "pick" }, new string[] { "[[-2, -2, 1, 1], [2, 2, 4, 6]]", "[]", "[]", "[]", "[]", "[]" })]
    public void Solution(string[] funcs, string[] valStr)
    {
        var rects = valStr[0].To2dArr();
        Solution0497 obj = new(rects);
        for (int i = 1; i < funcs.Length; ++i)
        {
            switch (funcs[i])
            {
                case "pick":
                    var ok = false;
                    var actual = obj.Pick();
                    foreach (var r in rects)
                    {
                        if (actual[0] >= r[0] && actual[0] <= r[2] &&
                            actual[1] >= r[1] && actual[1] <= r[3])
                        {
                            ok = true;
                            break;
                        }
                    }
                    Assert.True(ok);
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
