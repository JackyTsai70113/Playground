namespace playground.UnitTest;

public class NumberOfPowerfulIntTest
{
    [Theory]
    [InlineData(20, 1159, 5, "120", 2)]
    [InlineData(1, 6000, 4, "124", 5)]
    [InlineData(1, 971, 9, "17", 10)]
    [InlineData(12345, 1000000000000000, 9, "1", 99999999998765)]
    [InlineData(15, 215, 6, "10", 2)]
    [InlineData(1000, 2000, 4, "3000", 0)]
    public void NumberOfPowerfulInt(long start, long finish, int limit, string s, long expected)
    {
        var actual = NumberOfPowerfulInt29.NumberOfPowerfulInt(start, finish, limit, s);
        Assert.Equal(expected, actual);
    }
}
