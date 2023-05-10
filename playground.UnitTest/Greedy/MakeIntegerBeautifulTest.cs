using playground.Greedy;

namespace playground.UnitTest.Greedy;

public class MakeIntegerBeautifulTest
{
    [Theory]
    [InlineData(16, 6, 4)]
    [InlineData(467, 6, 33)]
    [InlineData(1, 1, 0)]
    public void MakeIntegerBeautiful(int n, int target, int expected)
    {
        var actual = MakeIntegerBeautifulClass.MakeIntegerBeautiful(n, target);
        Assert.Equal(expected, actual);
    }
}
