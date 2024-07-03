namespace playground.UnitTest;

public class MaximumLengthTest3201
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, 4)]
    [InlineData(new int[] { 1, 2, 1, 1, 2, 1, 2 }, 6)]
    [InlineData(new int[] { 1, 3 }, 2)]
    public void MaximumLength(int[] nums, int expected)
    {
        var actual = MaximumLength3201.MaximumLength(nums);
        Assert.Equal(expected, actual);
    }
}
