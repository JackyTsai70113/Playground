using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0118_GenerateTest
{
    [Theory]
    [InlineData(5, "[[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]")]
    [InlineData(1, "[[1]]")]
    public void Generate(int n, string expected)
    {
        var actual = _0118_Generate.Generate(n);
        Assert.Equal(expected.To2dArr(), actual);
    }
}
