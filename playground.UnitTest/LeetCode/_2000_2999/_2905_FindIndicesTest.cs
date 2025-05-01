using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2905_FindIndicesTest
{
    [Theory]
    [InlineData(new int[] { 1, 4, 1, 5 }, 2, 4, new int[] { 0, 3 })]
    [InlineData(new int[] { 5, 1, 4, 1 }, 2, 4, new int[] { 0, 3 })]
    [InlineData(new int[] { 2, 1 }, 0, 0, new int[] { 0, 0 })]
    [InlineData(new int[] { 1, 2, 3 }, 2, 4, new int[] { -1, -1 })]
    [InlineData(new int[] { 9, 5, 4 }, 1, 0, new int[] { 0, 1 })]
    public void FindIndices(int[] nums, int indexDifference, int valueDifference, int[] expected)
    {
        var actual = _2905_FindIndices.FindIndices(nums, indexDifference, valueDifference);
        Assert.Equal(expected, actual);
    }
}
