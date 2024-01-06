namespace playground.UnitTest;

public class MinOperationsTest
{
    [Theory]
    [InlineData("[2,1,3,4]", 1, 2)]
    [InlineData("[2,0,2,0]", 0, 0)]
    public void MinOperations(string nums, int k, int expected)
    {
        var actual = MinOperations29.MinOperations(nums.ToArr(), k);
        Assert.Equal(expected, actual);
    }
}
