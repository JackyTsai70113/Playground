namespace playground.UnitTest;

public class _3202_MaximumLengthTest
{
    [Theory]
    [InlineData(new int[] { 1, 3 }, 2, 2)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2, 5)]
    [InlineData(new int[] { 1, 4, 2, 3, 1, 4 }, 3, 4)]
    public void MaximumLength(int[] nums, int k, int expected)
    {
        var actual = _3202_MaximumLength.MaximumLength(nums, k);
        Assert.Equal(expected, actual);
    }
}
