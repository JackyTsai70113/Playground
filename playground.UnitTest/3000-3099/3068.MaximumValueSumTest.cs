namespace playground.UnitTest;

public class MaximumValueSumTest3068
{
    [Theory]
    [InlineData(new int[] { 1, 2, 1 }, 3, "[[0,1],[0,2]]", 6)]
    [InlineData(new int[] { 1, 2, 1, 2 }, 3, "[[0,1],[0,2],[0,3]]", 8)]
    [InlineData(new int[] { 2, 3 }, 7, "[[0,1]]", 9)]
    [InlineData(new int[] { 24, 78, 1, 97, 44 }, 6, "[[0,2],[1,2],[4,2],[3,4]]", 260)]
    [InlineData(new int[] { 7, 7, 7, 7, 7, 7 }, 3, "[[0,1],[0,2],[0,3],[0,4],[0,5]]", 42)]
    public static void MaximumValueSum(int[] nums, int k, string edges, long expected)
    {
        var actual = MaximumValueSum3068.MaximumValueSum(nums, k, edges.To2dArr());
        Assert.Equal(expected, actual);
    }
}
