namespace playground.UnitTest;

public class ChalkReplacerTest
{
    [Theory]
    [InlineData("[5,1,5]", 22, 0)]
    [InlineData("[3,4,1,2]", 25, 1)]
    [InlineData("[1,1,1,1]", 3, 3)]
    public void ChalkReplacer(string A, int k, int expected)
    {
        var actual = ChalkReplacer_1894.ChalkReplacer(A.ToArr(), k);
        Assert.Equal(expected, actual);
    }
}
