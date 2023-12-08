namespace playground.UnitTest;

public class SumNumbersTest_0129
{
    [Theory]
    [InlineData("[1,2,3]", 25)]
    [InlineData("[4,9,0,5,1]", 1026)]
    public void SumNumbers(string root, int expected)
    {
        var actual = SumNumbers_0129.SumNumbers(root.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
