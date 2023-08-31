using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class GetMaxLenTest
{
    [Theory]
    [InlineData(new int[] { 1, -2, -3, 4 }, 4)]
    [InlineData(new int[] { 0, 1, -2, -3, -4 }, 3)]
    [InlineData(new int[] { -1, -2, -3, 0, 1 }, 2)]
    public void GetMaxLen(int[] A, int expected)
    {
        var actual = GetMaxLenClass.GetMaxLen(A);
        Assert.Equal(expected, actual);
    }
}
