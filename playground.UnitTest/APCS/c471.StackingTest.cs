namespace playground.UnitTest;

public class StackingTestc471
{
    [Theory]
    [InlineData(2, "[20,10]", "[1,1]", 10)]
    [InlineData(2, "[1,2]", "[3,4]", 4)]
    [InlineData(3, "[3,4,5]", "[1,2,3]", 19)]
    public void Stacking(int n, string weights, string times, long expected)
    {
        var actual = Stackingc471.Stacking(n, weights.ToArr(), times.ToArr());
        Assert.Equal(expected, actual);
    }
}
