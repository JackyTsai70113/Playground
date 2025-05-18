using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3069_ResultArrayTest
{
    [Theory]
    [InlineData("[2,1,3]", "[2,3,1]")]
    [InlineData("[5,4,3,8]", "[5,3,4,8]")]
    public void ResultArray(string nums, string expected)
    {
        var actual = _3069_ResultArray.ResultArray(nums.ToArr());
        Assert.Equal(expected.ToArr(), actual);
    }
}
