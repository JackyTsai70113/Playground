namespace playground.UnitTest;

public class AlternatingSubarrayTest2756
{
    [Theory]
    [InlineData(new int[] { 2, 3, 4, 3, 4 }, 4)]
    [InlineData(new int[] { 4, 5, 6 }, 2)]
    [InlineData(new int[] { 21, 9, 5 }, -1)]
    public void AlternatingSubarray(int[] nums, int expected)
    {
        var actual = AlternatingSubarray2756.AlternatingSubarray(nums);
        Assert.Equal(expected, actual);
    }
}
