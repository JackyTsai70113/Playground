namespace playground.UnitTest;

public class MaxSpendingTest
{
    [Theory]
    [InlineData("[[8,5,2],[6,4,1],[9,7,3]]", 285)]
    [InlineData("[[10,8,6,4,2],[9,7,5,3,2]]", 386)]
    public void MinOperations(string vs, long expected)
    {
        var actual = MaxSpending_2931.MaxSpending(vs.To2dArr());
        Assert.Equal(expected, actual);
    }
}
