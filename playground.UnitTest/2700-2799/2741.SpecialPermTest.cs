namespace playground.UnitTest;

public class SpecialPermTest2741
{
    [Theory]
    [InlineData(new int[] { 2, 6 }, 2)]
    [InlineData(new int[] { 2, 3, 6 }, 2)]
    [InlineData(new int[] { 1, 4, 3 }, 2)]
    [InlineData(new int[] { 1, 2, 4, 8 }, 24)]
    [InlineData(new int[] { 1, 2, 4, 8, 16, 32, 64 }, 5040)]
    public void SpecialPerm(int[] nums, int expected)
    {
        var actual = SpecialPerm2741.SpecialPerm(nums);
        Assert.Equal(expected, actual);
    }
}
