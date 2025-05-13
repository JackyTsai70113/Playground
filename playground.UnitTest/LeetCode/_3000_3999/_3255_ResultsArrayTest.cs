using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3255_ResultsArrayTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 3, 2, 5 }, 3, new int[] { 3, 4, -1, -1, -1 })]
    [InlineData(new int[] { 2, 2, 2, 2, 2 }, 4, new int[] { -1, -1 })]
    [InlineData(new int[] { 3, 2, 3, 2, 3, 2 }, 2, new int[] { -1, 3, -1, 3, -1 })]
    public void ResultsArray(int[] nums, int k, int[] expected)
    {
        var actual = _3255_ResultsArray.ResultsArray(nums, k);
        Assert.Equal(expected, actual);
    }
}
