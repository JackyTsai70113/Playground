namespace playground.UnitTest;

public class FindRadiusTest0475
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 2 }, 1)]
    [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 4 }, 1)]
    [InlineData(new int[] { 1, 5 }, new int[] { 2 }, 3)]
    public void FindRadius(int[] houses, int[] heaters, int expected)
    {
        var actual = FindRadius0475.FindRadius(houses, heaters);
        Assert.Equal(expected, actual);
    }
}
