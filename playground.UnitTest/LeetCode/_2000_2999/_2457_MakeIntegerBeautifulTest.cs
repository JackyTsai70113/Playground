using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2457_MakeIntegerBeautifulTest
{
    [Theory]
    [InlineData(16, 6, 4)]
    [InlineData(467, 6, 33)]
    [InlineData(1, 1, 0)]
    [InlineData(14674, 6, 326)]
    public void MakeIntegerBeautiful(int n, int target, int expected)
    {
        var actual = _2457_MakeIntegerBeautiful.MakeIntegerBeautiful(n, target);
        Assert.Equal(expected, actual);
    }
};