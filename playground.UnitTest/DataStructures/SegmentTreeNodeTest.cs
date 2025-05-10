using playground.DataStructures;

namespace playground.UnitTest;

public class SegmentTreeNodeTest
{
    [Theory]
    [InlineData(new int[] { 2, 3, 1, 8, 5, 15, 3, 7, 4 }, 2, 4, 14, 2, 5, 18)]
    [InlineData(new int[] { 2, 3, 1, 8, 5, 15, 3, 7, 4 }, 1, 3, 12, 2, 5, 16)]
    public void GetSegmentTreeSum(int[] nums, int start, int end, int expectedSum, int index, int val, int expectedSum2)
    {
        var segment = new SegmentTreeNode(0, nums.Length - 1, nums);
        var sum = segment.GetSum(start, end);
        Assert.Equal(expectedSum, sum);
        segment.UpdateTree(index, val);
        var sum2 = segment.GetSum(start, end);
        Assert.Equal(expectedSum2, sum2);
    }
}
