using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3537_SpecialGridTest
{
    [Theory]
    [InlineData(0, "[[0]]")]
    [InlineData(1, "[[3,0],[2,1]]")]
    [InlineData(2, "[[15,12,3,0],[14,13,2,1],[11,8,7,4],[10,9,6,5]]")]
    public void Test(int n, string expected)
    {
        var s = _3537_SpecialGrid.SpecialGrid(n);
        Assert.Equal(expected.To2dArr(), s);
    }
}
