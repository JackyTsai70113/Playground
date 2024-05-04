namespace playground.UnitTest;

public class SetStationsTest_c575
{
    [Theory]
    [InlineData(2, new int[] { 5, 2, 1, 8, 7 }, 3)]
    [InlineData(1, new int[] { 7, 5, 1, 2, 8 }, 7)]
    public void SetStations(int k, int[] positions, int expected)
    {
        var actual = SetStations_c575.SetStations(k, positions);
        Assert.Equal(expected, actual);
    }
}
