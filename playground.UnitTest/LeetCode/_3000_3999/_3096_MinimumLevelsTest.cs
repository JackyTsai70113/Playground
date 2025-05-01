namespace playground.UnitTest;

public class _3096_MinimumLevelsTest
{
    [Theory]
    [InlineData(new int[] { 1, 0, 1, 0 }, 1)]
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, 3)]
    [InlineData(new int[] { 0, 0 }, -1)]
    public void MinimumLevels(int[] possible, int expected)
    {
        var actual = _3096_MinimumLevels.MinimumLevels(possible);
        Assert.Equal(expected, actual);
    }
}
