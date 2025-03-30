namespace playground.UnitTest;

public class CountPairsTest2824
{
    [Theory]
    [InlineData("[-1,1,2,3,1]", 2, 3)]
    [InlineData("[-6,2,5,-2,-7,-1,3]", -2, 10)]
    public void CountPairs(string nums, int target, int expected)
    {
        var actual = CountPairs2824.CountPairs(nums.ToArr(), target);
        Assert.Equal(expected, actual);
    }
}
