namespace playground.UnitTest;

public class HanoiTest
{
    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 3)]
    [InlineData(3, 7)]
    public void Hanoi(int n, int expected)
    {
        var actual = playground.Hanoi.HanoiSteps(n);
        Assert.Equal(expected, actual);
    }
}
