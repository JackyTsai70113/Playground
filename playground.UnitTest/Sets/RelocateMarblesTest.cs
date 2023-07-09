using playground.Sets;

namespace playground.UnitTest.Sets;

public class RelocateMarblesTest
{
    [Theory]
    [InlineData(new int[] { 1, 6, 7, 8 }, new int[] { 1, 7, 2 }, new int[] { 2, 9, 5 }, new int[] { 5, 6, 8, 9 })]
    [InlineData(new int[] { 1, 1, 3, 3 }, new int[] { 1, 3 }, new int[] { 2, 2 }, new int[] { 2 })]
    public void RelocateMarbles(int[] nums, int[] f, int[] t, int[] expected)
    {
        var actual = RelocateMarblesClass.RelocateMarbles(nums, f, t);
        Assert.Equal(expected, actual);
    }
}
