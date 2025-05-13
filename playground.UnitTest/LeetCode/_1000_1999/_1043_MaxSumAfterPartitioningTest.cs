namespace playground.UnitTest.LeetCode._1000_1999;

public class _1043_MaxSumAfterPartitioningTest
{
    [Theory]
    [InlineData("[1,15,7,9]", 3, 54)]
    [InlineData("[1,15,7,9,2,5,10]", 3, 84)]
    [InlineData("[1,4,1,5,7,3,6,1,9,9,3]", 4, 83)]
    [InlineData("[1]", 1, 1)]
    public void MaxSumAfterPartitioning(string A, int k, int expected)
    {
        var actual = _1043_MaxSumAfterPartitioning.MaxSumAfterPartitioning(A.ToArr(), k);
        Assert.Equal(expected, actual);
    }
}
