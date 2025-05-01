namespace playground.UnitTest;

public class _3158_DuplicateNumbersXORTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 1, 3 }, 1)]
    [InlineData(new int[] { 1, 2, 3 }, 0)]
    [InlineData(new int[] { 1, 2, 2, 1 }, 3)]
    public void DuplicateNumbersXOR(int[] nums, int expected)
    {
        var actual = _3158_DuplicateNumbersXOR.DuplicateNumbersXOR(nums);
        Assert.Equal(expected, actual);
    }
}
