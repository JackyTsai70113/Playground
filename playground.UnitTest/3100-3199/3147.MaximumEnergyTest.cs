namespace playground.UnitTest;

public class MaximumEnergyTest3147
{
    [Theory]
    [InlineData(new int[] { 5, 2, -10, -5, 1 }, 3, 3)]
    [InlineData(new int[] { -2, -3, -1 }, 2, -1)]
    public void MaximumEnergy(int[] A, int k, int expected)
    {
        var actual = MaximumEnergy3147.MaximumEnergy(A, k);
        Assert.Equal(expected, actual);
    }
}
