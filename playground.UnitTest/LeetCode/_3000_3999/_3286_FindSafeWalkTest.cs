namespace playground.UnitTest.LeetCode._3000_3999;

public class _3286_FindSafeWalkTest
{
    [Theory]
    [InlineData("[[0,1,0,0,0],[0,1,0,1,0],[0,0,0,1,0]]", 1, true)]
    [InlineData("[[0,1,1,0,0,0],[1,0,1,0,0,0],[0,1,1,1,0,1],[0,0,1,0,1,0]]", 3, false)]
    [InlineData("[[1,1,1],[1,0,1],[1,1,1]]", 5, true)]
    public void FindSafeWalk(string grid, int health, bool expected)
    {
        var actual = _3286_FindSafeWalk.FindSafeWalk(grid.To2dArr(), health);
        Assert.Equal(expected, actual);
    }
}
