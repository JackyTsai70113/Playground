namespace playground.UnitTest;

public class GetSneakyNumbersTest3289
{
    [Theory]
    [InlineData(new int[] { 0, 1, 1, 0 }, new int[] { 0, 1 })]
    [InlineData(new int[] { 0, 3, 2, 1, 3, 2 }, new int[] { 2, 3 })]
    public void GetSneakyNumbers(int[] nums, int[] expected)
    {
        var actual = GetSneakyNumbers3289.GetSneakyNumbers(nums);
        Assert.Equal(expected, actual.OrderBy(x => x));
    }
}
