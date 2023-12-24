namespace playground.UnitTest;

public class PlacedCoinsTest2973
{
    [Theory]
    [InlineData("[[0,1],[0,2],[0,3],[0,4],[0,5]]", "[1,2,3,4,5,6]", "[120,1,1,1,1,1]")]
    [InlineData("[[0,1],[0,2],[1,3],[1,4],[1,5],[2,6],[2,7],[2,8]]", "[1,4,2,3,5,7,8,-4,2]", "[280,140,32,1,1,1,1,1,1]")]
    [InlineData("[[0,1],[0,2]]", "[1,2,-2]", "[0,1,1]")]
    [InlineData("[[0,2],[0,6],[1,4],[3,5],[7,6],[3,6],[1,8],[3,1],[9,3]]", "[63,13,-6,20,56,-14,61,25,-99,54]", "[215208,0,1,77616,1,1,184464,1,1,1]")]
    [InlineData("[[0,8],[8,1],[9,2],[4,6],[7,4],[3,7],[3,8],[5,8],[5,9]]", "[-4,83,-97,40,86,-85,-6,-84,-16,-53]", "[709070,1,1,43344,1,0,1,43344,709070,1]")]
    public void PlacedCoins(string edges, string cost, string expected)
    {
        var actual = PlacedCoins2973.PlacedCoins(edges.To2dArr(), cost.ToArr());
        Assert.Equal(expected.ToArr<long>(), actual);
    }
}
