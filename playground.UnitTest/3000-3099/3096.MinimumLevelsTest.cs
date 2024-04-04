namespace playground.UnitTest;

public class MinimumLevelsTest3096
{
    [Theory]
    [InlineData(new int[] { 1, 0, 1, 0 }, 1)]
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, 3)]
    [InlineData(new int[] { 0, 0 }, -1)]
    public void MinimumLevels(int[] possible, int expected)
    {
        var actual = MinimumLevels3096.MinimumLevels(possible);
        Assert.Equal(expected, actual);
    }
}
