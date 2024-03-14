namespace playground.UnitTest;

public class CountSubarraysTest2302
{
    [Theory]
    [InlineData("[2,1,4,3,5]", 10, 6)]
    [InlineData("[1,1,1]", 5, 5)]
    public void CountSubarrays(string nums, long k, long expected)
    {
        var actual = CountSubarrays2302.CountSubarrays(nums.ToArr(), k);
        Assert.Equal(expected, actual);
    }
}
