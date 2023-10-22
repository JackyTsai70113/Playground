using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class MaximumScoreTest
{
    [Theory]
    [InlineData(new int[] { 1, 4, 3, 7, 4, 5 }, 3, 15)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2, 9)]
    [InlineData(new int[] { 5, 4, 3, 2, 1 }, 2, 9)]
    [InlineData(new int[] { 5, 5, 4, 5, 4, 1, 1, 1 }, 0, 20)]
    public void MaximumScore(int[] nums, int k, int expected)
    {
        var actual = MaximumScoreClass.MaximumScore(nums, k);
        Assert.Equal(expected, actual);
    }
}
