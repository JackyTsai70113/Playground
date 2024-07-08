namespace playground.UnitTest;

public class PassThePillowTest2582
{
    [Theory]
    [InlineData(4, 5, 2)]
    [InlineData(3, 2, 3)]
    public void PassThePillow
(int n, int time, int expected)
    {
        var actual = PassThePillow2582.PassThePillow(n, time);
        Assert.Equal(expected, actual);
    }
}
