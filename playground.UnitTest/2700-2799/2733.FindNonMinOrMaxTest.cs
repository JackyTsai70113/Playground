namespace playground.UnitTest;

public class FindNonMinOrMaxTest_2733
{
    [Theory]
    [InlineData("[3,2,1,4]", "[2,3]")]
    [InlineData("[1,2]", "[-1]")]
    [InlineData("[2,1,3]", "[2]")]
    [InlineData("[3,30,24]", "[24]")]
    public void FindNonMinOrMax(string nums, string expected)
    {
        var actual = FindNonMinOrMax_2733.FindNonMinOrMax(nums.ToArr());
        Assert.Contains(actual, expected.ToArr());
    }
}
