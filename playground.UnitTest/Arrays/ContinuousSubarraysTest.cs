using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class ContinuousSubarraysTest
{
    [Theory]
    [InlineData(new int[] { 5, 4, 2, 4 }, 8)]
    [InlineData(new int[] { 1, 2, 3 }, 6)]
    public void ContinuousSubarrays(int[] nums, int expected)
    {
        var actual = ContinuousSubarraysClass.ContinuousSubarrays(nums);
        Assert.Equal(expected, actual);
    }
}
