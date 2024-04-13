namespace playground.UnitTest;

public class NumberOfSubarraysTest3113
{
    [Theory]
    [InlineData(new int[] { 1, 4, 3, 2, 4, 2, 3, 3, 2 }, 11)]
    [InlineData(new int[] { 1, 4, 3, 2, 2, 3, 3, 2 }, 12)]
    [InlineData(new int[] { 1, 4, 3, 3, 2 }, 6)]
    [InlineData(new int[] { 3, 3, 3 }, 6)]
    [InlineData(new int[] { 1 }, 1)]
    public void NumberOfSubarrays(int[] A, long expected)
    {
        var actual = NumberOfSubarrays3113.NumberOfSubarrays(A);
        Assert.Equal(expected, actual);
    }
}
