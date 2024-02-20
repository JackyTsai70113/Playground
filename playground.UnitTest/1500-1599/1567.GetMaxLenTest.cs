namespace playground.UnitTest;

public class GetMaxLenTest1567
{
    [Theory]
    [InlineData(new int[] { 1, -2, -3, 4 }, 4)]
    [InlineData(new int[] { 0, 1, -2, -3, -4 }, 3)]
    [InlineData(new int[] { -1, -2, -3, 0, 1 }, 2)]
    public void GetMaxLen(int[] A, int expected)
    {
        var actual = GetMaxLen1567.GetMaxLen(A);
        Assert.Equal(expected, actual);
    }
}
