using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0073_SetZeroesTest
{
    [Theory]
    [InlineData("[[1,1,1],[1,0,1],[1,1,1]]", "[[1,0,1],[0,0,0],[1,0,1]]")]
    [InlineData("[[0,1,2,0],[3,4,5,2],[1,3,1,5]]", "[[0,0,0,0],[0,4,5,0],[0,3,1,0]]")]
    public void SetZeroes(string A, string expected)
    {
        var actual = A.To2dArr();
        _0073_SetZeroes.SetZeroes(actual);
        Assert.Equal(expected.To2dArr(), actual);
    }
}
