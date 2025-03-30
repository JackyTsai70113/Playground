namespace playground.UnitTest;

public class DistributeCoinsTest0979
{
    [Theory]
    [InlineData("[3,0,0]", 2)]
    [InlineData("[0,3,0]", 3)]
    public static void DistributeCoins(string root, int expected)
    {
        var actual = DistributeCoins0979.DistributeCoins(root.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
