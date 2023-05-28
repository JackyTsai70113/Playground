using playground.BitManipulation;

namespace playground.UnitTest.BitManipulation;

public class MaxProductTest
{
    [Theory]
    [InlineData(new string[] { "abcw", "baz", "foo", "bar", "xtfn", "abcdef" }, 16)]
    [InlineData(new string[] { "a", "ab", "abc", "d", "cd", "bcd", "abcd" }, 4)]
    [InlineData(new string[] { "a", "aa", "aaa", "aaaa" }, 0)]
    public void MaxProduct(string[] ws, int expected)
    {
        var actual = MaxProductClass.MaxProduct(ws);
        Assert.Equal(expected, actual);
    }
}
