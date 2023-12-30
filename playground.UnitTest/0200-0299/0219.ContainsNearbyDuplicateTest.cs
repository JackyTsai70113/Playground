namespace playground.UnitTest;

public class ContainsNearbyDuplicateTest0219
{
    [Theory]
    [InlineData("[1,2,3,1]", 3, true)]
    [InlineData("[1,0,1,1]", 1, true)]
    [InlineData("[1,2,3,1,2,3]", 2, false)]
    public void ContainsNearbyDuplicate(string nums, int k, bool expected)
    {
        var actual = ContainsNearbyDuplicate0219.ContainsNearbyDuplicate(nums.ToArr(), k);
        Assert.Equal(expected, actual);
    }
}
