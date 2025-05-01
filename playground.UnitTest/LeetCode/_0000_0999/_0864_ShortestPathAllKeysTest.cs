using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0864_ShortestPathAllKeysTest
{
    [Theory]
    [InlineData(new string[] { "@.a..", "###.#", "b.A.B" }, 8)]
    [InlineData(new string[] { "@..aA", "..B#.", "....b" }, 6)]
    [InlineData(new string[] { "@...a", ".###A", "b.BCc" }, 10)]
    [InlineData(new string[] { "@Aa" }, -1)]
    public void ShortestPathAllKeys(string[] grid, int expected)
    {
        var actual = _0864_ShortestPathAllKeys.ShortestPathAllKeys(grid);
        Assert.Equal(expected, actual);
    }
}
