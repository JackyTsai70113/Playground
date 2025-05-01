using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2574_LeftRightDifferenceTest
{
    [Theory]
    [InlineData(new int[] { 10, 4, 8, 3 }, new int[] { 15, 1, 11, 22 })]
    [InlineData(new int[] { 1 }, new int[] { 0 })]
    public void LeftRightDifference(int[] nums, int[] expected)
    {
        var actual = _2574_LeftRightDifference.LeftRightDifference(nums);
        Assert.Equal(expected, actual);
    }
}
