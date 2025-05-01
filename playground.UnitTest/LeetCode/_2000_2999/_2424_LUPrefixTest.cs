using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2424_LUPrefixTest
{
    [Theory]
    [InlineData(new string[] { "LUPrefix", "upload", "longest", "upload", "longest", "upload", "longest" }, "[[4], [3], [], [1], [], [2], []]", "[null, null, 0, null, 1, null, 3]")]
    public void LUPrefix(string[] funcs, string valStr, string expectedStr)
    {
        var vals = valStr.To2dArr();
        var expected = expectedStr.ToArr<int?>();
        _2424_LUPrefix obj = new(vals[0][0]);
        for (int i = 1; i < funcs.Length; ++i)
        {
            switch (funcs[i])
            {
                case "upload":
                    obj.Upload(vals[i][0]);
                    break;
                case "longest":
                    Assert.Equal(expected[i], obj.Longest());
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
