using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0933_RecentCounterTest
{
    [Theory]
    [InlineData(
        new string[] { "RecentCounter", "ping", "ping", "ping", "ping" },
        "[[],[1],[100],[3001],[3002]]",
        "[null,1,2,3,3]")]
    public void RecentCounter(string[] functions, string valStr, string expectedStr)
    {
        var vals = valStr.To2dArr();
        var expected = expectedStr.ToArr<int?>();
        _0933_RecentCounter recentCounter = new();
        for (int i = 0; i < functions.Length; ++i)
        {
            switch (functions[i])
            {
                case "RecentCounter":
                    recentCounter = new();
                    break;
                case "ping":
                    var actual = recentCounter.Ping(vals[i][0]);
                    Assert.Equal(expected[i].Value, actual);
                    break;
                default:
                    break;
            }
        }
    }
}
