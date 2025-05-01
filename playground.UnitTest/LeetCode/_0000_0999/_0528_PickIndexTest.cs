using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0528_PickIndexTest
{
    [Theory]
    [InlineData(new string[] { "Solution", "pickIndex" }, "[[1],[]]", new string[] { null, "[0]" })]
    [InlineData(new string[] { "Solution", "pickIndex", "pickIndex", "pickIndex", "pickIndex" }, "[[1,100000],[],[],[],[]]", new string[] { null, "[0,1]", "[0,1]", "[0,1]" , "[0,1]" })]
    [InlineData(new string[] { "Solution", "pickIndex", "pickIndex", "pickIndex", "pickIndex" }, "[[100000,1],[],[],[],[]]", new string[] { null, "[0,1]", "[0,1]", "[0,1]" , "[0,1]" })]
    [InlineData(new string[] { "Solution", "pickIndex", "pickIndex", "pickIndex", "pickIndex", "pickIndex" }, "[[1,3],[],[],[],[],[]]", new string[] { null, "[0,1]", "[0,1]", "[0,1]", "[0,1]", "[0,1]" })]
    public void PickIndex(string[] functions, string valStr, string[] expected)
    {
        var vals = valStr.To2dArr();
        _0528_PickIndex obj = new(vals[0]);
        for (int i = 1; i < functions.Length; ++i)
        {
            switch (functions[i])
            {
                case "pickIndex":
                    var actual = obj.PickIndex();
                    Assert.Contains(actual, expected[i].ToArr());
                    break;
                default:
                    break;
            }
        }
    }
}
