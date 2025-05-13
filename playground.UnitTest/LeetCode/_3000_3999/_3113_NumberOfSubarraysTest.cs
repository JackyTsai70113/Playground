namespace playground.UnitTest.LeetCode._3000_3999;

public class _3113_NumberOfSubarraysTest
{
    [Theory]
    [InlineData(new int[] { 1, 4, 3, 2, 4, 2, 3, 3, 2 }, 11)]
    [InlineData(new int[] { 1, 4, 3, 2, 2, 3, 3, 2 }, 12)]
    [InlineData(new int[] { 1, 4, 3, 3, 2 }, 6)]
    [InlineData(new int[] { 3, 3, 3 }, 6)]
    [InlineData(new int[] { 1 }, 1)]
    public void NumberOfSubarrays(int[] A, long expected)
    {
        var actual = _3113_NumberOfSubarrays.NumberOfSubarrays(A);
        Assert.Equal(expected, actual);
    }
}
