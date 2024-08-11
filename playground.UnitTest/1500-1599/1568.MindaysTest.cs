namespace playground.UnitTest;

public class MinDaysTest1568
{
    [Theory]
    [InlineData("[[0,1,0,0],[0,0,1,0],[0,0,0,0]]", 0)]
    [InlineData("[[0,1,1,0],[0,1,1,0],[0,0,0,0]]", 2)]
    [InlineData("[[1,1]]", 2)]
    [InlineData("[[1,1,0,1,1],[1,1,1,1,1],[1,1,0,1,1],[1,1,0,1,1]]", 1)]
    public void MinDays(string A, int expected)
    {
        var actual = new MinDays1568().MinDays(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
