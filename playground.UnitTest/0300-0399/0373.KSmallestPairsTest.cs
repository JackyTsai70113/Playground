namespace playground.UnitTest;

public class KSmallestPairsTest0373
{
    [Theory]
    [InlineData(new int[] { 1, 7, 11 }, new int[] { 2, 4, 6 }, 3, "[[1,2],[1,4],[1,6]]")]
    [InlineData(new int[] { 1, 1, 2 }, new int[] { 1, 2, 3 }, 2, "[[1,1],[1,1]]")]
    [InlineData(new int[] { 1, 2 }, new int[] { 3 }, 3, "[[1,3],[2,3]]")]
    public void FindMin(int[] num1, int[] nums2, int k, string expected)
    {
        var actual = KSmallestPairs0373.KSmallestPairs(num1, nums2, k);
        Assert.Equal(expected.To2dArr(), actual);
    }
}
