using playground.APCS;

namespace playground.UnitTest;

public class F638_CutTest
{
    [Theory]
    [InlineData(6, 2, new int[] { 5, 3, 4, 2, 6, 2 }, 10)]
    [InlineData(6, 2, new int[] { 4, 2, 7, 3, 1, 5 }, 8)]
    [InlineData(7, 3, new int[] { 5, 2, 6, 3, 1, 4, 8 }, 9)]
    [InlineData(7, 1, new int[] { 2, 4, 1, 3, 7, 6, 9 }, 7)]
    [InlineData(7, 3, new int[] { 2, 4, 1, 3, 7, 6, 9 }, 11)]
    public void CutTest(int n, int k, int[] nums, int expected)
    {
        var actual = F638_Cut.Cut(n, k, nums);
        Assert.Equal(expected, actual);
    }
}
