namespace playground.UnitTest;

public class FindPeakElementTest0162
{
    [Theory]
    [InlineData("[1,2,3,1]", 2)]
    [InlineData("[1,2,1,3,5,6,4]", 5)]
    [InlineData("[1,2,3,4]", 3)]
    [InlineData("[1,2,3]", 2)]
    [InlineData("[3,2,1]", 0)]
    [InlineData("[4,3,2,1]", 0)]
    [InlineData("[2,1]", 0)]
    public void FindPeakElement(string nums, int expected)
    {
        var actual = FindPeakElement0162.FindPeakElement(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
