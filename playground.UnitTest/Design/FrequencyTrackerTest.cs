using playground.Design;

namespace playground.UnitTest.Design;

public class FrequencyTrackerTest
{
    [Theory]
    [InlineData(new string[] { "FrequencyTracker", "add", "add", "hasFrequency" }, "[[], [3], [3], [2]]", new string[] { null, null, null, "true" })]
    [InlineData(new string[] { "FrequencyTracker", "add", "deleteOne", "hasFrequency" }, "[[],[1],[1],[1]]", new string[] { null, null, null, "false" })]
    [InlineData(new string[] { "FrequencyTracker", "hasFrequency", "add", "hasFrequency" }, "[[],[2],[3],[1]]", new string[] { null, "false", null, "true" })]
    public void FrequencyTracker(string[] funcs, string b, string[] expected)
    {
        var vals = b.To2dArr();
        FrequencyTracker ft = new();
        for (int i = 1; i < funcs.Length; ++i)
        {
            switch (funcs[i])
            {
                case "add":
                    ft.Add(vals[i][0]);
                    break;
                case "hasFrequency":
                    Assert.Equal(bool.Parse(expected[i]), ft.HasFrequency(vals[i][0]));
                    break;
                case "deleteOne":
                    ft.DeleteOne(vals[i][0]);
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
