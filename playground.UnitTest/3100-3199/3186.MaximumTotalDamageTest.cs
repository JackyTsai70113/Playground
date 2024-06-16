namespace playground.UnitTest;

public class MaximumTotalDamageTest3186
{
    [Theory]
    [InlineData(new int[] { 1, 1, 1, 1 }, 4)]
    [InlineData(new int[] { 1, 1, 3, 4 }, 6)]
    [InlineData(new int[] { 7, 1, 6, 6 }, 13)]
    [InlineData(new int[] { 4, 1, 2, 2, 6, 2, 5, 3 }, 12)]
    public void MaximumTotalDamage(int[] power, long expected)
    {
        var actual = MaximumTotalDamage3186.MaximumTotalDamage(power);
        Assert.Equal(expected, actual);
    }
}
