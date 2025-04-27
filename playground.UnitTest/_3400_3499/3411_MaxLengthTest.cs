using playground._3400_3499;

namespace playground.UnitTest._3400_3499;

public class _3411_MaxLengthTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 1, 2, 1, 1, 1 }, 5)]
    [InlineData(new int[] { 2, 3, 4, 5, 6 }, 3)]
    [InlineData(new int[] { 1, 2, 3, 1, 4, 5, 1 }, 5)]
    [InlineData(new int[] { 2, 6 }, 2)]
    [InlineData(new int[] { 2, 2, 8 }, 2)]
    public void MinStartingIndex(int[] A, long expected)
    {
        var actual = _3411_MaxLength.MaxLength(A);
        Assert.Equal(expected, actual);
    }
}
