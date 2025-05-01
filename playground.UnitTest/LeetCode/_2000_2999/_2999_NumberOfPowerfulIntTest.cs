using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2999_NumberOfPowerfulIntTest
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
        var actual = _2999_NumberOfPowerfulInt.NumberOfPowerfulInt(start, finish, limit, s);
        Assert.Equal(expected, actual);
    }
}
