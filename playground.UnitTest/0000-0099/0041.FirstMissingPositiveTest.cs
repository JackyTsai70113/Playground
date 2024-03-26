namespace playground.UnitTest;

public class FirstMissingPositiveTest0041
{
    [Theory]
    [InlineData("[1,2,0]", 3)]
    [InlineData("[3,4,-1,1]", 2)]
    [InlineData("[7,8,9,11,12]", 1)]
    [InlineData("[1]", 2)]
    public void FirstMissintPositive(string nums, int expected)
    {
        var actual = FirstMissingPositive0041.FirstMissingPositive(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
