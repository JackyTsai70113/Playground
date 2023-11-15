namespace playground.UnitTest;

public class CheckArrayTest
{
    [Theory]
    [InlineData(new int[] { 2, 2, 3, 1, 1, 0 }, 3, true)]
    [InlineData(new int[] { 1, 3, 1, 1 }, 2, false)]
    [InlineData(new int[] { 1 }, 2, false)]
    public void CheckArray(int[] nums, int k, bool expected)
    {
        var actual = CheckArray_2772.CheckArray(nums, k);
        Assert.Equal(expected, actual);
    }
}
