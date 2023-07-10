using playground.BreadthFirstSearch;

namespace playground.UnitTest.BreadthFirstSearch;

public class ShortestPathAllKeysTest
{
    [Theory]
    [InlineData(new string[] { "@.a..","###.#","b.A.B" }, 8)]
    [InlineData(new string[] { "@..aA","..B#.","....b" }, 6)]
    [InlineData(new string[] { "@Aa" }, -1)]
    public void ShortestPathAllKeys(string[] grid, int expected)
    {
        var actual = ShortestPathAllKeysClass.ShortestPathAllKeys(grid);
        Assert.Equal(expected, actual);
    }
}
