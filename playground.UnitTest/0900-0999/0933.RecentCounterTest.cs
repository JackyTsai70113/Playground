namespace playground.UnitTest;

public class RecentCounterTest_0933
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
        RecentCounter0933 recentCounter = new();
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
