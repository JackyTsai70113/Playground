namespace playground.UnitTest;

public class _3005_MaxFrequencyElementsTest
{
    [Theory]
    [InlineData("[1,2,2,3,1,4]", 4)]
    [InlineData("[1,2,3,4,5]", 5)]
    public void MissingInteger(string nums, int expected)
    {
        var actual = _3005_MaxFrequencyElements.MaxFrequencyElements(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
