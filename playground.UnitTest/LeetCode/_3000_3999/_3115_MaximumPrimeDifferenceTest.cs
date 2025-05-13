namespace playground.UnitTest.LeetCode._3000_3999;

public class _3115_MaximumPrimeDifferenceTest
{
    [Theory]
    [InlineData(new int[] { 4, 2, 9, 5, 3 }, 3)]
    [InlineData(new int[] { 4, 8, 2, 8 }, 0)]
    public void MaximumPrimeDifference(int[] nums, int expected)
    {
        var actual = _3115_MaximumPrimeDifference.MaximumPrimeDifference(nums);
        Assert.Equal(expected, actual);
    }
}
