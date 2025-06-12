using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3576_CanMakeEqualTest
{
    [Theory]
    [InlineData(new int[] { 1, -1, 1, -1, 1 }, 3, true)]
    [InlineData(new int[] { -1, -1, -1, 1, 1, 1 }, 5, false)]
    [InlineData(new int[] { -1, 1, 1, -1, -1, -1, 1, 1, -1, -1, 1, 1, 1, 1, -1, -1 }, 3, false)]
    public void CanMakeEqual(int[] A, int k, bool expected)
    {
        var actual = _3576_CanMakeEqual.CanMakeEqual(A, k);
        Assert.Equal(expected, actual);
    }
}
