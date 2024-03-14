namespace playground.UnitTest;

public class RotateTest0189
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new[] { 5, 6, 7, 1, 2, 3, 4 })]
    [InlineData(new[] { -1, -100, 3, 99 }, 2, new[] { 3, 99, -1, -100 })]
    public void Rotate(int[] nums, int k, int[] expected)
    {
        new Rotate0189().Rotate(nums, k);
        Assert.Equal(expected, nums);
    }
}
