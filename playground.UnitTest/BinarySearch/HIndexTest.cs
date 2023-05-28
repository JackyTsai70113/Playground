using playground.BinarySearch;

namespace playground.UnitTest.BinarySearch;

public class HIndexTest
{
    [Theory]
    [InlineData(new int[] { 0, 1, 3, 5, 6 }, 3)]
    [InlineData(new int[] { 1, 2, 100 }, 2)]
    [InlineData(new int[] { 0 }, 0)]
    public void HIndex(int[] A, int expected)
    {
        var actual = HIndexClass.HIndex(A);
        Assert.Equal(expected, actual);
    }
}
