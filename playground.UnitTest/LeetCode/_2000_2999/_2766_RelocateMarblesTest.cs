using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2766_RelocateMarblesTest
{
    [Theory]
    [InlineData(new int[] { 1, 6, 7, 8 }, new int[] { 1, 7, 2 }, new int[] { 2, 9, 5 }, new int[] { 5, 6, 8, 9 })]
    [InlineData(new int[] { 1, 1, 3, 3 }, new int[] { 1, 3 }, new int[] { 2, 2 }, new int[] { 2 })]
    public void RelocateMarbles(int[] nums, int[] moveFrom, int[] moveTo, int[] expected)
    {
        var actual = _2766_RelocateMarbles.RelocateMarbles(nums, moveFrom, moveTo);
        Assert.Equal(expected, actual);
    }
}
