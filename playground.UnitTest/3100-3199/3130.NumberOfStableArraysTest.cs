namespace playground.UnitTest;

public class NumberOfStableArraysTest3130
{
    [Theory]
    [InlineData(1, 1, 2, 2)]
    [InlineData(1, 2, 2, 3)]
    [InlineData(1, 2, 1, 1)]
    [InlineData(3, 3, 2, 14)]
    public void NumberOfStableArrays(int zero, int one, int limit, int expected)
    {
        var actual = NumberOfStableArrays3130.NumberOfStableArrays(zero, one, limit);
        Assert.Equal(expected, actual);
    }
}
