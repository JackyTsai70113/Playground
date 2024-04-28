namespace playground.UnitTest;

public class MedianOfUniquenessArrayTest3134
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 1)]
    [InlineData(new int[] { 3, 4, 3, 4, 5 }, 2)]
    [InlineData(new int[] { 4, 3, 5, 4 }, 2)]
    [InlineData(new int[] { 46, 73, 46, 46, 46 }, 1)]
    public void MedianOfUniquenessArray(int[] nums, int expected)
    {
        var actual = MedianOfUniquenessArray3134.MedianOfUniquenessArray(nums);
        Assert.Equal(expected, actual);
    }
}
