namespace playground.UnitTest;

public class FindMaxLengthTest0525
{
    [Theory]
    [InlineData("[0,1]", 2)]
    [InlineData("[1,0,1]", 2)]
    [InlineData("[1,1]", 0)]
    public void KthSmallest(string nums, int expected)
    {
        var actual = FindMaxLength0525.FindMaxLength(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
