using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0066_PlusOneTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
    [InlineData(new int[] { 4, 3, 2, 1 }, new int[] { 4, 3, 2, 2 })]
    [InlineData(new int[] { 9 }, new int[] { 1, 0 })]
    public void PlusOne(int[] digits, int[] expected)
    {
        var actual = _0066_PlusOne.PlusOne(digits);
        Assert.Equal(expected, actual);
    }
}
