namespace playground.UnitTest;

public class MaximumPrimeDifferenceTest3115
{
    [Theory]
    [InlineData(new int[] { 4, 2, 9, 5, 3 }, 3)]
    [InlineData(new int[] { 4, 8, 2, 8 }, 0)]
    public void MaximumPrimeDifference(int[] nums, int expected)
    {
        var actual = MaximumPrimeDifference3115.MaximumPrimeDifference(nums);
        Assert.Equal(expected, actual);
    }
}
