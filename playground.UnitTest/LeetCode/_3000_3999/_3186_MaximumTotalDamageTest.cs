namespace playground.UnitTest;

public class _3186_MaximumTotalDamageTest
{
    [Theory]
    [InlineData(new int[] { 1, 1, 1, 1 }, 4)]
    [InlineData(new int[] { 1, 1, 3, 4 }, 6)]
    [InlineData(new int[] { 7, 1, 6, 6 }, 13)]
    [InlineData(new int[] { 4, 1, 2, 2, 6, 2, 5, 3 }, 12)]
    public void MaximumTotalDamage(int[] power, long expected)
    {
        var actual = _3186_MaximumTotalDamage.MaximumTotalDamage(power);
        Assert.Equal(expected, actual);
    }
}
