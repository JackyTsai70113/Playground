namespace playground.UnitTest;

public class NumRescueBoatsTest0881
{
    [Theory]
    [InlineData(new int[] { 1, 2 }, 3, 1)]
    [InlineData(new int[] { 3, 2, 2, 1 }, 3, 3)]
    [InlineData(new int[] { 3, 5, 3, 4 }, 5, 4)]
    [InlineData(new int[] { 3, 2, 3, 2, 2 }, 6, 3)]
    public void NumRescueBoats(int[] people, int limit, int expected)
    {
        var actual = NumRescueBoats0881.NumRescueBoats(people, limit);
        Assert.Equal(expected, actual);
    }
}
