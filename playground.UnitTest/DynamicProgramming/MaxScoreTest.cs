using playground.DynamicProgramming;

namespace playground.UnitTest.DynamicProgramming;

public class MaxScoreTest
{
    [Theory]
    [InlineData(new int[] { 1, 2 }, 1)]
    [InlineData(new int[] { 3, 4, 6, 8 }, 11)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 14)]
    public void MaxScore(int[] nums, int expected)
    {
        int actual = MaxScoreClass.MaxScore(nums);

        Assert.Equal(expected, actual);
    }
}
