using playground.UndirectedGraph;
using playground.UnitTest.Utils;

namespace playground.UnitTest.UndirectGraph;

public class CollectTheCoinsTest
{
    [Theory]
    [InlineData("[1,0,0,0,0,1]", "[[0,1],[1,2],[2,3],[3,4],[4,5]]", 2)]
    [InlineData("[0,0,0,1,1,0,0,1]", "[[0,1],[0,2],[1,3],[1,4],[2,5],[5,6],[5,7]]", 2)]
    public void CollectTheCoins(string a, string b, int expected)
    {
        var actual = CollectTheCoinsClass.CollectTheCoins(a.ToArr<int>(), b.To2dArr<int>());
        Assert.Equal(expected, actual);
    }
}
