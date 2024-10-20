using playground._3300_3399;

namespace playground.UnitTest._3300_3399;

public class _3325_NumberOfSubstringsTest
{
    [Theory]
    [InlineData("abacb", 2, 4)]
    [InlineData("abcde", 1, 15)]
    public void NumberOfSubstrings(string s, int k, int expected)
    {
        var actual = _3325_NumberOfSubstrings.NumberOfSubstrings(s, k);
        Assert.Equal(expected, actual);
    }
}
