namespace playground.UnitTest;

public class ResultArrayTest3069
{
    [Theory]
    [InlineData("[2,1,3]", "[2,3,1]")]
    [InlineData("[5,4,3,8]", "[5,3,4,8]")]
    public void ResultArray(string nums, string expected)
    {
        var actual = ResultArray3069.ResultArray(nums.ToArr());
        Assert.Equal(expected.ToArr(), actual);
    }
}
