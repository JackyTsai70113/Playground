namespace playground.UnitTest;

public class ShortestPathAllKeysTest0864
{
    [Theory]
    [InlineData(new string[] { "@.a..", "###.#", "b.A.B" }, 8)]
    [InlineData(new string[] { "@..aA", "..B#.", "....b" }, 6)]
    [InlineData(new string[] { "@...a", ".###A", "b.BCc" }, 10)]
    [InlineData(new string[] { "@Aa" }, -1)]
    public void ShortestPathAllKeys(string[] grid, int expected)
    {
        var actual = ShortestPathAllKeys0864.ShortestPathAllKeys(grid);
        Assert.Equal(expected, actual);
    }
}
