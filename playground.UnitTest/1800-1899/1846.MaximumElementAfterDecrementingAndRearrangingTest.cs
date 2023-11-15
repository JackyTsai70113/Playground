namespace playground.UnitTest;

public class MaximumElementAfterDecrementingAndRearrangingTest
{
    [Theory]
    [InlineData("[2,2,1,2,1]", 2)]
    [InlineData("[100,1,1000]", 3)]
    [InlineData("[1,2,3,4,5]", 5)]
    [InlineData("[2,2,2,10,2]", 3)]
    public void MaximumElementAfterDecrementingAndRearranging(string arr, int expected)
    {
        var actual = MaximumElementAfterDecrementingAndRearranging_1846.MaximumElementAfterDecrementingAndRearranging(arr.ToArr());
        Assert.Equal(expected, actual);
    }
}
