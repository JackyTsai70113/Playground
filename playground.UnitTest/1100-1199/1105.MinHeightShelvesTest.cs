namespace playground.UnitTest;

public class MinHeightShelvesTest1105
{
    [Theory]
    [InlineData("[[1,1],[2,3],[2,3],[1,1],[1,1],[1,1],[1,2]]", 4, 6)]
    [InlineData("[[1,3],[2,4],[3,2]]", 6, 4)]
    public void MinHeightShelves(string books, int shelfWidth, int expected)
    {
        var actual = MinHeightShelves1105.MinHeightShelves(books.To2dArr(), shelfWidth);
        Assert.Equal(expected, actual);
    }
}
