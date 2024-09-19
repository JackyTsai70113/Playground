namespace playground.UnitTest;

public class PairSumTest2130
{
    [Theory]
    [InlineData("[5,3]", 8)]
    [InlineData("[5,3,2,1]", 6)]
    [InlineData("[5,4,2,1]", 6)]
    [InlineData("[5,5,2,1]", 7)]
    public void PairSum(string a, int expected)
    {
        var actual = PairSum2130.PairSum(a.ToListNode());
        Assert.Equal(expected, actual);
    }
}
