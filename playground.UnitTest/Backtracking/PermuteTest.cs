using playground.Backtracking;

namespace playground.UnitTest.Backtracking;

public class PermuteTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, "[[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,2,1],[3,1,2]]")]
    [InlineData(new int[] { 0, 1 }, "[[0,1],[1,0]]")]
    public void Permute(int[] nums, string expected)
    {
        var actual = PermuteClass.Permute(nums);
        Assert.Equal(expected.To2dArr(), actual.ToArray());
    }
}
