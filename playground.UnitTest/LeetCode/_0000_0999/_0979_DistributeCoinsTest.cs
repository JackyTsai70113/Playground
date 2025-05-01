using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0979_DistributeCoinsTest
{
    [Theory]
    [InlineData("[3,0,0]", 2)]
    [InlineData("[0,3,0]", 3)]
    public static void DistributeCoins(string root, int expected)
    {
        var actual = _0979_DistributeCoins.DistributeCoins(root.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
