namespace playground.UnitTest;

public class _3289_GetSneakyNumbersTest
{
    [Theory]
    [InlineData(new int[] { 0, 1, 1, 0 }, new int[] { 0, 1 })]
    [InlineData(new int[] { 0, 3, 2, 1, 3, 2 }, new int[] { 2, 3 })]
    public void GetSneakyNumbers(int[] nums, int[] expected)
    {
        var actual = _3289_GetSneakyNumbers.GetSneakyNumbers(nums);
        Assert.Equal(expected, actual.OrderBy(x => x));
    }
}
