using playground._2800_2899;

namespace playground.UnitTest._2800_2899;

public class _2818_MaximumScoreTest
{
    [Theory]
    [InlineData(new int[] { 8, 3, 9, 3, 8 }, 2, 81)]
    [InlineData(new int[] { 19, 12, 14, 6, 10, 18 }, 3, 4788)]
    [InlineData(new int[] { 3289, 2832, 14858, 22011 }, 6, 256720975)]
    public void MaximumScore(int[] nums, int k, int expected)
    {
        var actual = _2818_MaximumScore.MaximumScore(nums, k);
        Assert.Equal(expected, actual);
    }
}
