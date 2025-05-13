namespace playground.UnitTest.LeetCode._1000_1999;

public class _1463_CherryPickupTest
{
    [Theory]
    [InlineData("[[3,1,1],[2,5,1],[1,5,5],[2,1,1]]", 24)]
    [InlineData("[[1,0,0,0,0,0,1],[2,0,0,0,0,3,0],[2,0,9,0,0,0,0],[0,3,0,5,4,0,0],[1,0,2,3,0,0,6]]", 28)]
    [InlineData("[[0,10,1,3,5,1,8],[2,7,9,1,3,8,9],[8,9,5,9,0,7,9],[2,5,7,10,9,3,9],[0,5,3,4,9,0,1],[4,8,8,8,6,3,8],[1,6,10,10,10,10,3],[2,9,3,2,1,3,5],[9,2,6,10,9,6,5],[2,2,2,9,1,7,1]]", 149)]
    public void CherryPickup(string grid, int expected)
    {
        var actual = _1463_CherryPickup.CherryPickup(grid.To2dArr());
        Assert.Equal(expected, actual);
    }
}
