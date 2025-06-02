using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1387_GetKthTest
{
    [Theory]
    [InlineData(12, 15, 2, 13)]
    [InlineData(7, 11, 4, 7)]
    public void GetKth(int lo, int hi, int k, int expected)
    {
        var actual = _1387_GetKth.GetKth(lo, hi, k);
        Assert.Equal(expected, actual);
    }
}
