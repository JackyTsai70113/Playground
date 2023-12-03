namespace playground.UnitTest;

public class NumberOfSequenceTest_2954
{
    [Theory]
    [InlineData(5, "[0,4]", 4)]
    [InlineData(5, "[1]", 4)]
    [InlineData(5, "[0]", 1)]
    [InlineData(4, "[1]", 3)]
    [InlineData(6, "[1,5]", 16)]
    [InlineData(9, "[2,6]", 840)]
    [InlineData(100000, "[0]", 1)]
    [InlineData(100000, "[60]", 842631137)]
    public void NumberOfSequence(int n, string sick, int expected)
    {
        var actual = new NumberOfSequence_2954().NumberOfSequence(n, sick.ToArr());
        Assert.Equal(expected, actual);
    }
}
