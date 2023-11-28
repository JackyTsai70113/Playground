namespace playground.UnitTest;

public class MaxAreaTest
{
    [Theory]
    [InlineData("[1,8,6,2,5,4,8,3,7]", 49)]
    [InlineData("[1,1]", 1)]
    [InlineData("[1,2,4,3]", 4)]
    [InlineData("[1,3,2,5,25,24,5]", 24)]
    public void MaxArea(string A, int expected)
    {
        var actual = MaxArea_0011.MaxArea(A.ToArr());
        Assert.Equal(expected, actual);
    }
}
