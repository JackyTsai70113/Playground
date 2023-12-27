namespace playground.UnitTest;

public class KthSmallestTest_0230
{
    [Theory]
    [InlineData("[3,1,4,null,2]", 1, 1)]
    [InlineData("[5,3,7,2,4,6,null,1]", 3, 3)]
    [InlineData("[5,3,7,2,4,6,null,1]", 6, 6)]
    public void KthSmallest(string nums, int k, int expected)
    {
        var actual = KthSmallest_0230.KthSmallest(nums.ToTreeNode(), k);
        Assert.Equal(expected, actual);
    }
}
