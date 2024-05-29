namespace playground.UnitTest;

public class SpecialArrayTest1608
{
    [Theory]
    [InlineData(new int[] { 3, 5 }, 2)]
    [InlineData(new int[] { 0, 0 }, -1)]
    [InlineData(new int[] { 0, 4, 3, 0, 4 }, 3)]
    [InlineData(new int[] { 3, 6, 7, 7, 0 }, -1)]
    public void SpecialArray(int[] nums, int expected)
    {
        var actual = SpecialArray1608.SpecialArray(nums);
        Assert.Equal(expected, actual);
    }
}
