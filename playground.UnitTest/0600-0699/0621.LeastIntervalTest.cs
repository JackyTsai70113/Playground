namespace playground.UnitTest;

public class LeastIntervalTest0621
{
    [Theory]
    [InlineData(new char[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 1, 6)]
    [InlineData(new char[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 2, 8)]
    [InlineData(new char[] { 'A', 'C', 'B', 'B', 'D', 'B' }, 1, 6)]
    [InlineData(new char[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 3, 10)]
    public void LeastInterval(char[] tasks, int n, int expected)
    {
        var actual = LeastInterval0621.LeastInterval(tasks, n);
        Assert.Equal(expected, actual);
    }
}
