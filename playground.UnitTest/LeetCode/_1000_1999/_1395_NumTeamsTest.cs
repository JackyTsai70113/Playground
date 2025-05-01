namespace playground.UnitTest;

public class _1395_NumTeamsTest
{
    [Theory]
    [InlineData(new int[] { 2, 5, 3, 4, 1 }, 3)]
    [InlineData(new int[] { 2, 1, 3 }, 0)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 4)]
    public void NumTeams(int[] A, int expected)
    {
        var actual = _1395_NumTeams.NumTeams(A);
        Assert.Equal(expected, actual);
    }
}
