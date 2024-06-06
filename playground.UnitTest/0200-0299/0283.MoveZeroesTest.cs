namespace playground.UnitTest;

public class MoveZeroesTest0283
{
    [Theory]
    [InlineData(new[] { 0 }, new[] { 0 })]
    [InlineData(new[] { 0, 1, 0, 3, 12 }, new[] { 1, 3, 12, 0, 0 })]
    [InlineData(new[] { 4, 2, 4, 0, 0, 3, 0, 5, 1, 0 }, new[] { 4, 2, 4, 3, 5, 1, 0, 0, 0, 0 })]
    public void MoveZeroes(int[] nums, int[] expected)
    {
        MoveZeroes0283.MoveZeroes(nums);
        Assert.Equal(expected, nums);
    }
}
