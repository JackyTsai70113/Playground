namespace playground.UnitTest;

public class _3046_IsPossibleToSplitTest
{
    [Theory]
    [InlineData("[1,1,2,2,3,4]", true)]
    [InlineData("[1,1,1,1]", false)]
    public void IsPossibleToSplit(string nums, bool expected)
    {
        var actual = _3046_IsPossibleToSplit.IsPossibleToSplit(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
