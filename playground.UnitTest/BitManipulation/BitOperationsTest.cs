using playground.BitManipulation;

namespace playground.UnitTest.BitManipulation;

public class BitOperationsTest
{
    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(4, 1)]
    [InlineData(5, 2)]
    [InlineData(6, 2)]
    [InlineData(7, 3)]
    [InlineData(8, 1)]
    [InlineData(12, 2)]
    [InlineData(13, 3)]
    public void BitOperationsPopCount(int num, int expected)
    {
        var actual = BitOperationsClass.PopCount(num);
        Assert.Equal(expected, actual);
    }
}
