using System.Text.Json;

namespace playground.UnitTest;

public class RandomizedSetTest
{
    [Theory]
    [InlineData(new string[] { "RandomizedSet", "insert", "remove", "insert", "getRandom", "remove", "insert", "getRandom" }, "[[], [1], [2], [2], [], [1], [2], []]", "[null, true, false, true, \"[1,2]\", true, false, \"[2]\"]")]
    public void RandomizedSet(string[] functions, string valStr, string expectedStr)
    {
        var vals = valStr.To2dArr();
        var expected = expectedStr.ToArr<JsonElement>();
        RandomizedSet obj = new();
        for (int i = 0; i < functions.Length; ++i)
        {
            switch (functions[i])
            {
                case "RandomizedSet":
                    obj = new();
                    break;
                case "insert":
                    var b1 = obj.Insert(vals[i][0]);
                    Assert.Equal(expected[i].GetBoolean(), b1);
                    break;
                case "remove":
                    var b2 = obj.Remove(vals[i][0]); Assert.Equal(expected[i].GetBoolean(), b2);
                    break;
                case "getRandom":
                    var random = obj.GetRandom();
                    Assert.Contains(random, expected[i].GetString().ToArr());
                    break;
                default:
                    break;
            }
        }
    }
}
