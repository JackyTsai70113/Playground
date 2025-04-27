using playground._3400_3499;

namespace playground.UnitTest._3400_3499;

public class _3404_NumberOfSubsequencesTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 3, 6, 1 }, 1)]
    [InlineData(new int[] { 3, 4, 3, 4, 3, 4, 3, 4 }, 3)]
    [InlineData(new int[] { 10, 17, 5, 1, 3, 16, 6, 18 }, 1)]
    public void MinStartingIndex(int[] A, long expected)
    {
        var actual = _3404_NumberOfSubsequences.NumberOfSubsequences(A);
        Assert.Equal(expected, actual);
    }
}
