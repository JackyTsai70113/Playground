using playground._3400_3499;

namespace playground.UnitTest._3400_3499;

public class _3446_SortMatrixTest
{
    [Theory]
    [InlineData("[[1,7,3],[9,8,2],[4,5,6]]", "[[8,2,3],[9,6,7],[4,5,1]]")]
    [InlineData("[[0,1],[1,2]]", "[[2,1],[1,0]]")]
    [InlineData("[[1]]", "[[1]]")]
    public void CountSubstrings(string A, string expected)
    {
        var actual = _3446_SortMatrix.SortMatrix(A.To2dArr());
        Assert.Equal(expected.To2dArr(), actual);
    }
}
