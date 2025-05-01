using playground._3200_3299;

namespace playground.UnitTest._3200_3299;

public class _3255_ResultsArrayTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 3, 2, 5 }, 3, new int[] { 3, 4, -1, -1, -1 })]
    [InlineData(new int[] { 2, 2, 2, 2, 2 }, 4, new int[] { -1, -1 })]
    [InlineData(new int[] { 3, 2, 3, 2, 3, 2 }, 2, new int[] { -1, 3, -1, 3, -1 })]
    public void ResultsArray(int[] nums, int k, int[] expected)
    {
        var actual = _3255_ResultsArray.ResultsArray(nums, k);
        Assert.Equal(expected, actual);
    }
}
