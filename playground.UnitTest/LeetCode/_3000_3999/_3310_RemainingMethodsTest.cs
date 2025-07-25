using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3310_RemainingMethodsTest
{
    [Theory]
    [InlineData(4, 1, "[[1,2],[0,1],[3,2]]", new int[] { 0, 1, 2, 3 })]
    [InlineData(5, 0, "[[1,2],[0,2],[0,1],[3,4]]", new int[] { 3, 4 })]
    [InlineData(3, 2, "[[1,2],[0,1],[2,0]]", new int[] { })]
    public void RemainingMethods(int n, int k, string A, int[] expected)
    {
        var actual = _3310_RemainingMethods.RemainingMethods(n, k, A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
