namespace playground.UnitTest;

public class IsHappyTest0202
{
    [Theory]
    [InlineData(19, true)]
    [InlineData(1, true)]
    [InlineData(7, true)]
    [InlineData(2, false)]
    public void IsHappy(int n, bool expected)
    {
        var actual = IsHappy0202.IsHappy(n);
        Assert.Equal(expected, actual);
    }
}
