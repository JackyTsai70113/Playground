namespace playground.UnitTest;

public class MaxFrequencyElementsTest3005
{
    [Theory]
    [InlineData("[1,2,2,3,1,4]", 4)]
    [InlineData("[1,2,3,4,5]", 5)]
    public void MissingInteger(string nums, int expected)
    {
        var actual = MaxFrequencyElements3005.MaxFrequencyElements(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
