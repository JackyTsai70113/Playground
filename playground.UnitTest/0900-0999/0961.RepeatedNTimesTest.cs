namespace playground.UnitTest;

public class RepeatedNTimesTest0961
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 3 }, 3)]
    [InlineData(new int[] { 2, 1, 2, 5, 3, 2 }, 2)]
    [InlineData(new int[] { 5, 1, 5, 2, 5, 3, 5, 4 }, 5)]
    [InlineData(new int[] { 2, 6, 2, 1 }, 2)]
    [InlineData(new int[] { 2, 6, 1, 2 }, 2)]
    public void RepeatedNTimes(int[] nums, int expected)
    {
        var actual = RepeatedNTimes0961.RepeatedNTimes(nums);
        Assert.Equal(expected, actual);
    }
}
