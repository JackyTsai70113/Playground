namespace playground.UnitTest;

public class FindMinTest0153
{
    [Theory]
    [InlineData("[3,4,5,1,2]", 1)]
    [InlineData("[4,5,6,7,0,1,2]", 0)]
    [InlineData("[11,13,15,17]", 11)]
    [InlineData("[3,4,0,1,2]", 0)]
    [InlineData("[4,5,6,-1,0,1,2]", -1)]
    [InlineData("[0,1]", 0)]
    [InlineData("[1,0]", 0)]
    public void FindMin(string num, int expected)
    {
        var actual = FindMin0153.FindMin(num.ToArr());
        Assert.Equal(expected, actual);
    }
}
