using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0901_StockSpannerTest
{
    [Theory]
    [InlineData(
        new string[] { "StockSpanner", "next", "next", "next", "next", "next", "next", "next" },
        "[[],[100],[80],[60],[70],[60],[75],[85]]",
        "[null,1,1,1,2,1,4,6]")]
    public void StockSpanner(string[] functions, string valStr, string expectedStr)
    {
        var vals = valStr.To2dArr();
        var expected = expectedStr.ToArr<int?>();
        _0901_StockSpanner stockSpanner = new();
        for (int i = 1; i < functions.Length; ++i)
        {
            switch (functions[i])
            {
                case "next":
                    var actual = stockSpanner.Next(vals[i][0]);
                    Assert.Equal(expected[i].Value, actual);
                    break;
            }
        }
    }
}
