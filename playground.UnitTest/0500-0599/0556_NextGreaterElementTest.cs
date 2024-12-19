using playground._0500_0599;

namespace playground.UnitTest._0500_0599;

public class _0556_NextGreaterElementTest
{
    [Theory]
    [InlineData(2147483467, 2147483476)]
    [InlineData(2147483468, 2147483486)]
    [InlineData(2147483476, 2147483647)]
    [InlineData(2147483486, -1)]
    [InlineData(123, 132)]
    [InlineData(132, 213)]
    [InlineData(213, 231)]
    [InlineData(231, 312)]
    [InlineData(312, 321)]
    [InlineData(321, -1)]
    public void NextGreaterElement(int n, int expected)
    {
        var actual = _0556_NextGreaterElement.NextGreaterElement(n);
        Assert.Equal(expected, actual);
    }
}
