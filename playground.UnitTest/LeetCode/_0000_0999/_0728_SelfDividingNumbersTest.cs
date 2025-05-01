using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0728_SelfDividingNumbersTest
{
    [Theory]
    [InlineData(1, 22, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22 })]
    [InlineData(47, 85, new int[] { 48, 55, 66, 77 })]
    public void SelfDividingNumbers(int left, int right, IList<int> expected)
    {
        var actual = _0728_SelfDividingNumbers.SelfDividingNumbers(left, right);
        Assert.Equal(expected, actual);
    }
}
