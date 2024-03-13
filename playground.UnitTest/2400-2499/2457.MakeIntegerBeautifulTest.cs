namespace playground.UnitTest;

public class MakeIntegerBeautifulTest2457
{
    [Theory]
    [InlineData(16, 6, 4)]
    [InlineData(467, 6, 33)]
    [InlineData(1, 1, 0)]
    [InlineData(14674, 6, 326)]
    public void MakeIntegerBeautiful(int n, int target, int expected)
    {
        var actual = MakeIntegerBeautiful2457.MakeIntegerBeautiful(n, target);
        Assert.Equal(expected, actual);
    }
}
