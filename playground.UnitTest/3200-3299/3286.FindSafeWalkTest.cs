namespace playground.UnitTest;

public class FindSafeWalkTest3286
{
    [Theory]
    [InlineData("[[0,1,0,0,0],[0,1,0,1,0],[0,0,0,1,0]]", 1, true)]
    [InlineData("[[0,1,1,0,0,0],[1,0,1,0,0,0],[0,1,1,1,0,1],[0,0,1,0,1,0]]", 3, false)]
    [InlineData("[[1,1,1],[1,0,1],[1,1,1]]", 5, true)]
    public void FindSafeWalk(string grid, int health, bool expected)
    {
        var actual = FindSafeWalk3286.FindSafeWalk(grid.To2dArr(), health);
        Assert.Equal(expected, actual);
    }
}
