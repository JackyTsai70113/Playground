using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2954_NumberOfSequenceTest
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
        var actual = new _2954_NumberOfSequence().NumberOfSequence(n, sick.ToArr());
        Assert.Equal(expected, actual);
    }
}
