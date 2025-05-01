using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0046_PermuteTest
{
    [Theory]
    [InlineData("[1,2,3]", "[[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]")]
    [InlineData("[0,1]", "[[0,1],[1,0]]")]
    [InlineData("[1]", "[[1]]")]
    public void Permute(string nums, string expected)
    {
        var actual = _0046_Permute.Permute(nums.ToArr());
        Assert.Equal(expected.To2dArr(), actual);
    }
}
