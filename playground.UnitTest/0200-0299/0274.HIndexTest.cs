namespace playground.UnitTest;

public class HIndexTest_0274
{
    [Theory]
    [InlineData("[0,1,3,5,6]", 3)]
    [InlineData("[1,2,100]", 2)]
    [InlineData("[1,3,1]", 1)]
    public void HIndex(string A, int expected)
    {
        var actual = HIndex_0274.HIndex(A.ToArr());
        Assert.Equal(expected, actual);
    }
}
