using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2741_SpecialPermTest
{
    [Theory]
    [InlineData(new int[] { 2, 6 }, 2)]
    [InlineData(new int[] { 2, 3, 6 }, 2)]
    [InlineData(new int[] { 1, 4, 3 }, 2)]
    [InlineData(new int[] { 1, 2, 4, 8 }, 24)]
    [InlineData(new int[] { 1, 2, 4, 8, 16, 32, 64 }, 5040)]
    public void SpecialPerm(int[] nums, int expected)
    {
        var actual = _2741_SpecialPerm.SpecialPerm(nums);
        Assert.Equal(expected, actual);
    }
}
