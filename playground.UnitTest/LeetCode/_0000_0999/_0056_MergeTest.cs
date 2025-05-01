using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0056_MergeTest
{
    [Theory]
    [InlineData("[[1,3],[2,6],[8,10],[15,18]]", "[[1,6],[8,10],[15,18]]")]
    [InlineData("[[1,4],[4,5]]", "[[1,5]]")]
    public void Merge(string A, string expected)
    {
        var actual = _0056_Merge.Merge(A.To2dArr());
        Assert.Equal(expected.To2dArr(), actual);
    }
}
