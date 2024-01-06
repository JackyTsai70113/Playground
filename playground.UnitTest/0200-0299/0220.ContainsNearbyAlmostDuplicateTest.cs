namespace playground.UnitTest;

public class ContainsNearbyAlmostDuplicateTest0220
{
    [Theory]
    [InlineData("[-3,3]", 2, 4, false)]
    [InlineData("[1,3,6,2]", 1, 2, true)]
    [InlineData("[4,1,6,3]", 4, 1, true)]
    [InlineData("[1,2,3,1]", 3, 0, true)]
    [InlineData("[1,5,9,1,5,9]", 2, 3, false)]
    public void ContainsNearbyAlmostDuplicate(string nums, int indexDiff, int valueDiff, bool expected)
    {
        var actual = ContainsNearbyAlmostDuplicate0220.ContainsNearbyAlmostDuplicate(nums.ToArr(), indexDiff, valueDiff);
        Assert.Equal(expected, actual);
    }
}
