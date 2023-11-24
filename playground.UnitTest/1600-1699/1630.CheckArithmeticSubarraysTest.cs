namespace playground.UnitTest;

public class CheckArithmeticSubarraysTest_1630
{
    [Theory]
    [InlineData("[4,6,5,9,3,7]", "[0,0,2]", "[2,3,5]", "[true,false,true]")]
    [InlineData("[-12,-9,-3,-12,-6,15,20,-25,-20,-15,-10]", "[0,1,6,4,8,7]", "[4,4,9,7,9,10]", "[false,true,false,false,true,true]")]
    public void CheckArithmeticSubarrays(string nums, string l, string r, string expected)
    {
        var actual = CheckArithmeticSubarrays_1630.CheckArithmeticSubarrays(nums.ToArr(), l.ToArr(), r.ToArr());
        Assert.Equal(expected.ToArr<bool>(), actual);
    }
}
