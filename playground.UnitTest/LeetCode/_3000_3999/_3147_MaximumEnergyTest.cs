namespace playground.UnitTest;

public class _3147_MaximumEnergyTest
{
    [Theory]
    [InlineData(new int[] { 5, 2, -10, -5, 1 }, 3, 3)]
    [InlineData(new int[] { -2, -3, -1 }, 2, -1)]
    public void MaximumEnergy(int[] A, int k, int expected)
    {
        var actual = _3147_MaximumEnergy.MaximumEnergy(A, k);
        Assert.Equal(expected, actual);
    }
}
