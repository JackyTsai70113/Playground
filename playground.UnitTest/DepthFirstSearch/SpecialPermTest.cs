using playground.DepthFirstSearch;

namespace playground.UnitTest.DepthFirstSearch;

public class SpecialPermTest
{
    [Theory]
    [InlineData(new int[] { 2, 3, 6 }, 2)]
    [InlineData(new int[] { 1, 4, 3 }, 2)]
    [InlineData(new int[] { 1, 2, 4, 8 }, 24)]
    [InlineData(new int[] { 1, 2, 4, 8, 16, 32, 64 }, 5040)]
    public void SpecialPerm(int[] nums, int expected)
    {
        var actual = SpecialPermClass.SpecialPerm(nums);
        Assert.Equal(expected, actual);
    }
}
