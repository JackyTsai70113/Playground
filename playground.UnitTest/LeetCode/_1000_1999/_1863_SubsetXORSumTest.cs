using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1863_SubsetXORSumTest
{
    [Theory]
    [InlineData(new int[] { 1, 3 }, 6)]
    [InlineData(new int[] { 5, 1, 6 }, 28)]
    [InlineData(new int[] { 3, 4, 5, 6, 7, 8 }, 480)]
    public void SubsetXORSum(int[] nums, int expected)
    {
        var actual = _1863_SubsetXORSum.SubsetXORSum(nums);
        Assert.Equal(expected, actual);
    }
}
