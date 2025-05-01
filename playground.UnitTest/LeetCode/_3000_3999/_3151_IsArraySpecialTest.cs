namespace playground.UnitTest;

public class _3151_IsArraySpecialTest
{
    [Theory]
    [InlineData(new int[] { 1 }, true)]
    [InlineData(new int[] { 2, 1, 4 }, true)]
    [InlineData(new int[] { 4, 3, 1, 6 }, false)]
    public static void IsArraySpecial(int[] nums, bool expected)
    {
        var actual = _3151_IsArraySpecial.IsArraySpecial(nums);
        Assert.Equal(expected, actual);
    }
}
