namespace playground.UnitTest;

public class SubsetsTest0078
{
    [Theory]
    [InlineData(new int[] { 1 }, "[[],[1]]")]
    [InlineData(new int[] { 1, 2 }, "[[],[1],[2],[1,2]]")]
    [InlineData(new int[] { 1, 2, 3 }, "[[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]")]
    public void Subsets(int[] nums, string expected)
    {
        var actual = Subsets0078.Subsets(nums);
        Assert.Equal(expected.To2dArr(), actual);
    }

    [Theory]
    [InlineData(new int[] { 1 }, "[[],[1]]")]
    [InlineData(new int[] { 1, 2 }, "[[],[2],[1],[1,2]]")]
    [InlineData(new int[] { 1, 2, 3 }, "[[],[3],[2],[2,3],[1],[1,3],[1,2],[1,2,3]]")]
    public void Subsets2(int[] nums, string expected)
    {
        var actual = Subsets0078.Subsets2(nums);
        Assert.Equal(expected.To2dArr(), actual);
    }
}
