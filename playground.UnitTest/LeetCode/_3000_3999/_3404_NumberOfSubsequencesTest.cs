using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3404_NumberOfSubsequencesTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 3, 6, 1 }, 1)]
    [InlineData(new int[] { 3, 4, 3, 4, 3, 4, 3, 4 }, 3)]
    [InlineData(new int[] { 10, 17, 5, 1, 3, 16, 6, 18 }, 1)]
    public void NumberOfSubsequences(int[] A, long expected)
    {
        var actual = _3404_NumberOfSubsequences.NumberOfSubsequences(A);
        Assert.Equal(expected, actual);
    }
}
