namespace playground.UnitTest;

public class ContainsDuplicateTest0217
{
    [Theory]
    [InlineData("[1,2,3,1]", true)]
    [InlineData("[1,2,3,4]", false)]
    [InlineData("[1,1,1,3,3,4,3,2,4,2]", true)]
    public void ContainsDuplicate(string nums, bool expected)
    {
        var actual = ContainsDuplicate0217.ContainsDuplicate(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
