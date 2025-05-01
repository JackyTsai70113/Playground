namespace playground.UnitTest;

public class _3134_MedianOfUniquenessArrayTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 1)]
    [InlineData(new int[] { 3, 4, 3, 4, 5 }, 2)]
    [InlineData(new int[] { 4, 3, 5, 4 }, 2)]
    [InlineData(new int[] { 46, 73, 46, 46, 46 }, 1)]
    public void MedianOfUniquenessArray(int[] nums, int expected)
    {
        var actual = _3134_MedianOfUniquenessArray.MedianOfUniquenessArray(nums);
        Assert.Equal(expected, actual);
    }
}
