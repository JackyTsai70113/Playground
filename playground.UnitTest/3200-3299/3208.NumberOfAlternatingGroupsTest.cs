namespace playground.UnitTest;

public class NumberOfAlternatingGroupsTest3208
{
    [Theory]
    [InlineData(new int[] { 0, 1, 1 }, 3, 1)]
    [InlineData(new int[] { 0, 1, 0, 1, 0 }, 3, 3)]
    [InlineData(new int[] { 0, 1, 0, 0, 1, 0, 1 }, 6, 2)]
    [InlineData(new int[] { 1, 1, 0, 1 }, 4, 0)]
    public void NumberOfAlternatingGroups(int[] A, int k, int expected)
    {
        var actual = NumberOfAlternatingGroups3208.NumberOfAlternatingGroups(A, k);
        Assert.Equal(expected, actual);
    }
}
