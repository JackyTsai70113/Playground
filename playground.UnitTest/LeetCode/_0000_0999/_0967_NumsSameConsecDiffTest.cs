using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0967_NumsSameConsecDiffTest
{
    [Theory]
    [InlineData(3, 7, new int[] { 181, 292, 707, 818, 929 })]
    [InlineData(2, 1, new int[] { 10, 12, 21, 23, 32, 34, 43, 45, 54, 56, 65, 67, 76, 78, 87, 89, 98 })]
    [InlineData(2, 0, new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99 })]
    public void NumsSameConsecDiff(int n, int k, int[] expected)
    {
        var actual = _0967_NumsSameConsecDiff.NumsSameConsecDiff(n, k);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(3, 7, new int[] { 181, 292, 707, 818, 929 })]
    [InlineData(2, 1, new int[] { 10, 12, 21, 23, 32, 34, 43, 45, 54, 56, 65, 67, 76, 78, 87, 89, 98 })]
    [InlineData(2, 0, new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99 })]
    public void NumsSameConsecDiff2(int n, int k, int[] expected)
    {
        var actual = _0967_NumsSameConsecDiff.NumsSameConsecDiff2(n, k);
        Assert.Equal(expected, actual);
    }
}
