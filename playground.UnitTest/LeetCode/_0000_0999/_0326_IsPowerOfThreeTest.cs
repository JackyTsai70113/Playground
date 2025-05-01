using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0326_IsPowerOfThreeTest
{
    [Theory]
    [InlineData(27, true)]
    [InlineData(0, false)]
    [InlineData(-1, false)]
    public void IsPowerOfThree(int n, bool expected)
    {
        var actual = _0326_IsPowerOfThree.IsPowerOfThree(n);
        Assert.Equal(expected, actual);
    }
}
