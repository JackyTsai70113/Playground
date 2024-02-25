namespace playground.UnitTest;

public class IsPossibleToSplitTest3046
{
    [Theory]
    [InlineData("[1,1,2,2,3,4]", true)]
    [InlineData("[1,1,1,1]", false)]
    public void IsPossibleToSplit(string nums, bool expected)
    {
        var actual = IsPossibleToSplit3046.IsPossibleToSplit(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
