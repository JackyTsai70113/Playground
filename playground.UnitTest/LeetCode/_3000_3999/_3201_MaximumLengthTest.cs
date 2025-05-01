namespace playground.UnitTest;

public class _3201_MaximumLengthTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, 4)]
    [InlineData(new int[] { 1, 2, 1, 1, 2, 1, 2 }, 6)]
    [InlineData(new int[] { 1, 3 }, 2)]
    public void MaximumLength(int[] nums, int expected)
    {
        var actual = _3201_MaximumLength.MaximumLength(nums);
        Assert.Equal(expected, actual);
    }
}
