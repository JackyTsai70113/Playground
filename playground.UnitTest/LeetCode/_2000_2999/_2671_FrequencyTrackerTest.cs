using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2671_FrequencyTrackerTest_cs
{
    [Theory]
    [InlineData(new string[] { "FrequencyTracker", "deleteOne", "add", "add", "hasFrequency" }, "[[], [3], [3], [3], [2]]", new object[] { null, null, null, null, true })]
    [InlineData(new string[] { "FrequencyTracker", "add", "deleteOne", "hasFrequency" }, "[[],[1],[1],[1]]", new object[] { null, null, null, false })]
    [InlineData(new string[] { "FrequencyTracker", "hasFrequency", "add", "hasFrequency" }, "[[],[2],[3],[1]]", new object[] { null, false, null, true })]
    public void FrequencyTracker(string[] funcs, string valStr, object[] expected)
    {
        var vals = valStr.To2dArr();
        _2671_FrequencyTracker obj = new();
        for (int i = 1; i < funcs.Length; ++i)
        {
            switch (funcs[i])
            {
                case "add":
                    obj.Add(vals[i][0]);
                    break;
                case "hasFrequency":
                    Assert.Equal(expected[i], obj.HasFrequency(vals[i][0]));
                    break;
                case "deleteOne":
                    obj.DeleteOne(vals[i][0]);
                    break;
                default:
                    throw new Exception();
            }
        }
    }

    [Theory]
    [InlineData(new string[] { "FrequencyTracker", "deleteOne", "add", "add", "hasFrequency" }, "[[], [3], [3], [3], [2]]", new object[] { null, null, null, null, true })]
    [InlineData(new string[] { "FrequencyTracker", "add", "deleteOne", "hasFrequency" }, "[[],[1],[1],[1]]", new object[] { null, null, null, false })]
    [InlineData(new string[] { "FrequencyTracker", "hasFrequency", "add", "hasFrequency" }, "[[],[2],[3],[1]]", new object[] { null, false, null, true })]
    public void FrequencyTracker2(string[] funcs, string valStr, object[] expected)
    {
        var vals = valStr.To2dArr();
        _2671_FrequencyTracker2 obj = new();
        for (int i = 1; i < funcs.Length; ++i)
        {
            switch (funcs[i])
            {
                case "add":
                    obj.Add(vals[i][0]);
                    break;
                case "hasFrequency":
                    Assert.Equal(expected[i], obj.HasFrequency(vals[i][0]));
                    break;
                case "deleteOne":
                    obj.DeleteOne(vals[i][0]);
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
