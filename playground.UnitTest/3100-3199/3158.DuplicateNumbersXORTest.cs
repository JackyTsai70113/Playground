namespace playground.UnitTest;

public class DuplicateNumbersXORTest3158
{
    [Theory]
    [InlineData(new int[] { 1, 2, 1, 3 }, 1)]
    [InlineData(new int[] { 1, 2, 3 }, 0)]
    [InlineData(new int[] { 1, 2, 2, 1 }, 3)]
    public void DuplicateNumbersXOR(int[] nums, int expected)
    {
        var actual = DuplicateNumbersXOR3158.DuplicateNumbersXOR(nums);
        Assert.Equal(expected, actual);
    }
}
