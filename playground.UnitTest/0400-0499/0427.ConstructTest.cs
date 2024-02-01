namespace playground.UnitTest;

public class ConstructTest0427
{
    [Theory]
    [InlineData("[[0,1],[1,0]]", "[[0,1],[1,0],[1,1],[1,1],[1,0]]")]
    [InlineData("[[1,1,1,1,0,0,0,0],[1,1,1,1,0,0,0,0],[1,1,1,1,1,1,1,1],[1,1,1,1,1,1,1,1],[1,1,1,1,0,0,0,0],[1,1,1,1,0,0,0,0],[1,1,1,1,0,0,0,0],[1,1,1,1,0,0,0,0]]", "[[0,1],[1,1],[0,1],[1,1],[1,0],null,null,null,null,[1,0],[1,0],[1,1],[1,1]]")]
    public void Construct(string grid, string expected)
    {
        var actual = Construct0427.Construct(grid.To2dArr());
        Assert.Equal(expected, actual.ToString());
    }
}
