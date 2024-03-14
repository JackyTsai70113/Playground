namespace playground.UnitTest;

public class NumSubarraysWithSumTest0930
{
    [Theory]
    [InlineData(new int[] { 1, 0, 1, 0, 1 }, 2, 4)]
    [InlineData(new int[] { 0, 0, 0, 0, 0 }, 0, 15)]
    public void NumSubarraysWithSum(int[] nums, int goal, int expected)
    {
        var actual = new NumSubarraysWithSum0930().NumSubarraysWithSum(nums, goal);
        Assert.Equal(expected, actual);
    }
}
