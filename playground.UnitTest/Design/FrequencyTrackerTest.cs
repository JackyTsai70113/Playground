using playground.Design;

namespace playground.UnitTest.Design;

public class FrequencyTrackerTest
{
    [Theory]
    [InlineData("[FrequencyTracker, add, add, hasFrequency]", "[[], [3], [3], [2]]", "[null,null,null,true]")]
    [InlineData("[FrequencyTracker,add,deleteOne,hasFrequency]", "[[],[1],[1],[1]]", "[null,null,null,false]")]
    [InlineData("[FrequencyTracker,hasFrequency,add,hasFrequency]", "[[],[2],[3],[1]]", "[null,false,null,true]")]
    public void FrequencyTracker(string a, string b, string expectedStr)
    {
        var funcs = a.ToArr<string>();

        var vals = b.To2dArr<int>();

        var expected = expectedStr.ToArr<string>();

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
