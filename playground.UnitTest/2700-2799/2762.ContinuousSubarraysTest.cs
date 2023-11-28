namespace playground.UnitTest.Arrays;

public class ContinuousSubarraysTest_2762
{
    [Theory]
    [InlineData(new int[] { 5, 4, 2, 4 }, 8)]
    [InlineData(new int[] { 1, 2, 3 }, 6)]
    public void ContinuousSubarrays(int[] nums, int expected)
    {
        var actual = ContinuousSubarrays_2762.ContinuousSubarrays(nums);
        Assert.Equal(expected, actual);
    }
}
