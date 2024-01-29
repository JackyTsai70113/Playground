namespace playground.UnitTest;

public class MaxSubArrayTest0053
{
    [Theory]
    [InlineData("[-2,1,-3,4,-1,2,1,-5,4]", 6)]
    [InlineData("[1]", 1)]
    [InlineData("[5,4,-1,7,8]", 23)]
    [InlineData("[-5,-1,-7,-8]", -1)]
    public void MaxSubArray(string A, int expected)
    {
        var actual = MaxSubArray0053.MaxSubArray(A.ToArr());
        Assert.Equal(expected, actual);
    }
}
