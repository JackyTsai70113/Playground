using playground.Arrays;
using playground.UnitTest.Utils;

namespace playground.UnitTest.Arrays;

public class ColorTheArrayTest
{
    [Theory]
    [InlineData(4, "[[0,2],[1,2],[3,1],[1,1],[2,1]]", "[0,1,1,0,2]")]
    [InlineData(1, "[[0,100000]]", "[0]")]
    public void ColorTheArray(int n, string queriesStr, string expectedStr)
    {
        var queries = queriesStr.To2dArr<int>();
        var actual = ColorTheArrayClass.ColorTheArray(n, queries);
        Assert.Equal(expectedStr.ToArr<int>(), actual);
    }
}
