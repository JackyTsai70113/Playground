namespace playground.UnitTest;

public class MaximumSubarraySumTest3026
{
    [Theory]
    [InlineData("[1,2,3,4,5,6]", 9, 0)]
    [InlineData("[1,2,3,4,5,6]", 1, 11)]
    [InlineData("[-1,3,2,4,5]", 3, 11)]
    [InlineData("[-1,-2,-3,-4]", 2, -6)]
    [InlineData("[1,3,10,3,3]", 2, 20)]
    [InlineData("[5,3,3]", 2, 11)]
    [InlineData("[3,3,2]", 1, 8)]
    public void MaximumSubarraySum(string A, int k, long expected)
    {
        var actual = MaximumSubarraySum3026.MaximumSubarraySum(A.ToArr(), k);
        Assert.Equal(expected, actual);
    }
}
