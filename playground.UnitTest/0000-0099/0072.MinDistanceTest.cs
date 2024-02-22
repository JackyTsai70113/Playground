namespace playground.UnitTest;

public class MinDistanceTest0072
{
    [Theory]
    [InlineData("horse", "ros", 3)]
    [InlineData("intention", "execution", 5)]
    public void MinDistance(string A, string B, int expected)
    {
        var actual = MinDistance0072.MinDistance(A, B);
        Assert.Equal(expected, actual);
    }
}
