using System.Text.Json;
using playground.Arrays;
using playground.UnitTest.Utils;

namespace playground.UnitTest.Arrays;

public class MostPopularCreatorTest
{
    [Theory]
    [InlineData("[alice,bob,alice,chris]", "[one,two,three,four]", "[5,10,5,4]", "[[alice,one],[bob,two]]")]
    [InlineData("[alice,alice,alice]", "[a,b,c]", "[1,2,2]", "[[alice,b]]")]
    [InlineData("[a,a]","[aa,a]", "[5,5]", "[[a,a]]")]
    public void MostPopularCreator(string a, string b, string c, string expected)
    {
        var actual = MostPopularCreatorClass.MostPopularCreator(a.ToArr<string>(), b.ToArr<string>(), c.ToArr<int>());
        var actualStr = JsonSerializer.Serialize(actual);
        var expectedStr = JsonSerializer.Serialize(expected.To2dArr<string>());
        Assert.Equal(expectedStr, actualStr);
    }
}
