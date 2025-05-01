using playground._1500_1599;

namespace playground.UnitTest._1500_1599;

public class _1574_FindLengthOfShortestSubarrayTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 10, 4, 2, 3, 5 }, 3)]
    [InlineData(new int[] { 5, 4, 3, 2, 1 }, 4)]
    [InlineData(new int[] { 1, 2, 3 }, 0)]
    [InlineData(new int[] { 2, 2, 2, 1, 1, 1 }, 3)]
    [InlineData(new int[] { 1, 3, 2, 4 }, 1)]
    public void FindLengthOfShortestSubarray(int[] arr, int expected)
    {
        var actual = _1574_FindLengthOfShortestSubarray.FindLengthOfShortestSubarray(arr);
        Assert.Equal(expected, actual);
    }
}
