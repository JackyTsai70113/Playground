namespace playground.UnitTest;

public class SumCountsTest_2916
{
    [Theory]
    [InlineData("[5,2,4,2,1,3,2,4,3,1]", 578)]
    [InlineData("[1,2,1]", 15)]
    [InlineData("[2,2]", 3)]
    [InlineData("[2]", 1)]
    public void SumCounts(string num, int expected)
    {
        var actual = new SumCounts_2916().SumCounts(num.ToArr());
        Assert.Equal(expected, actual);
    }
}
