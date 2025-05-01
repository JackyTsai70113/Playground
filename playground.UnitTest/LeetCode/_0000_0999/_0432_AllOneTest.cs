using playground.LeetCode._0000_0999;


using playground._0400_0499;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0432_AllOneTest
{
    [Theory]
    [InlineData(
        new string[] { "AllOne", "inc", "inc", "getMaxKey", "getMinKey", "inc", "getMaxKey", "getMinKey" },
        new string[] { "", "hello", "hello", "", "", "leet", "", "" },
        new string[] { null, null, null, "hello", "hello", null, "hello", "leet" })]
    [InlineData(
        new string[] { "AllOne", "inc", "inc", "inc", "inc", "getMaxKey", "inc", "inc", "inc", "dec", "inc", "inc", "inc", "getMaxKey" },
        new string[] { "", "hello", "goodbye", "hello", "hello", "", "leet", "code", "leet", "hello", "leet", "code", "code", "" },
        new string[] { null, null, null, null, null, "hello", null, null, null, null, null, null, null, "leet" })]
    [InlineData(
        new string[] { "AllOne", "inc", "inc", "inc", "inc", "inc", "dec", "dec", "getMaxKey", "getMinKey" },
        new string[] { "", "a", "b", "b", "b", "b", "b", "b", "", "" },
        new string[] { null, null, null, null, null, null, null, null, "b", "a" })]
    [InlineData(
        new string[] { "AllOne", "getMaxKey", "getMinKey", "inc", "inc", "inc", "inc", "inc", "inc", "dec", "dec", "getMinKey", "dec", "getMaxKey", "getMinKey" },
        new string[] { "", "", "", "a", "b", "b", "c", "c", "c", "b", "b", "", "a", "", "" },
        new string[] { null, "", "", null, null, null, null, null, null, null, null, "a", null, "c", "c" })]
    public void AllOne(string[] funcs, string[] vals, string[] expected)
    {
        _0432_AllOne obj = new();
        for (int i = 1; i < funcs.Length; ++i)
        {
            switch (funcs[i])
            {
                case "inc":
                    obj.Inc(vals[i]);
                    break;
                case "dec":
                    obj.Dec(vals[i]);
                    break;
                case "getMaxKey":
                    Assert.Equal(expected[i], obj.GetMaxKey());
                    break;
                case "getMinKey":
                    Assert.Equal(expected[i], obj.GetMinKey());
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
