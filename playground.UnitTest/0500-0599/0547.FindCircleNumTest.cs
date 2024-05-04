namespace playground.UnitTest;

public class FindCircleNumTest0547
{
    [Theory]
    [InlineData("[[1,1,0],[1,1,0],[0,0,1]]", 2)]
    public void FindCircleNum(string isConnected, int expected)
    {
        var actual = FindCircleNum0547.FindCircleNum(isConnected.To2dArr());
        Assert.Equal(expected, actual);
    }
}
