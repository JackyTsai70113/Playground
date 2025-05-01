using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2709_CanTraverseAllPairsTest
{
    [Theory]
    [InlineData(new int[] { 1 }, true)]
    [InlineData(new int[] { 2 }, true)]
    [InlineData(new int[] { 1, 1 }, false)]
    [InlineData(new int[] { 2, 3, 6 }, true)]
    [InlineData(new int[] { 3, 9, 5 }, false)]
    [InlineData(new int[] { 4, 12 }, true)]
    [InlineData(new int[] { 7, 36, 14, 42 }, true)]
    [InlineData(new int[] { 4, 3, 12, 8 }, true)]
    [InlineData(new int[] { 60, 78, 66, 66, 77, 70, 77 }, true)]
    [InlineData(new int[] { 60, 30, 75, 90, 90, 90, 5, 97 }, false)]
    [InlineData(new int[] { 1, 30, 75, 90, 90, 90, 5, 97 }, false)]
    [InlineData(new int[] { 924, 364, 294, 586, 780, 336, 210, 165, 462, 312, 285, 330, 78, 858, 390, 165, 330, 420, 858, 630, 858, 693, 234, 156, 840, 660, 735, 528, 390, 715, 616, 990, 924, 660, 858, 455, 840, 693, 525, 490, 910, 672, 546, 891, 693, 319, 858, 546, 770, 616, 715, 720, 630, 585, 840, 594, 630, 324, 924, 660, 24, 234, 455, 825, 273, 858, 825, 315, 462, 770, 840, 110, 228, 902, 688, 390, 935, 924, 924, 312, 462, 945, 572, 770, 572, 910, 182, 728, 570, 546, 462, 875, 462, 726, 546, 231, 924, 462, 490, 660, 231, 765, 325, 840, 847, 910, 660, 33, 840, 910, 105, 84, 910, 390, 819, 330, 572, 715, 385, 924, 110, 300, 546, 858, 315, 770, 156, 195, 657, 582, 520, 287, 714, 616, 910, 990, 54, 590, 585, 429, 924 }, true)]
    public void CanTraverseAllPairs(int[] nums, bool expected)
    {
        var actual = _2709_CanTraverseAllPairs.CanTraverseAllPairs(nums);
        Assert.Equal(expected, actual);
    }
}