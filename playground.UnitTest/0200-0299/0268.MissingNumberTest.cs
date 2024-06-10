namespace playground.UnitTest;

public class MissingNumberTest0268
{
    [Theory]
    [InlineData(new int[] { 3, 0, 1 }, 2)]
    [InlineData(new int[] { 0, 1 }, 2)]
    [InlineData(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8)]
    public void MissingNumber(int[] nums, int expected)
    {
        var actual = MissingNumber0268.MissingNumber(nums);
        Assert.Equal(expected, actual);
    }
}
