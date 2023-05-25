using playground.Backtracking;

namespace playground.UnitTest.Backtracking;

public class SumOfPowerTest
{
    [Theory]
    [InlineData("[2,1,4]", 141)]
    [InlineData("[1,1,1]", 7)]
    public void SumOfPower(string a, int expected)
    {
        var nums = a.ToArr();
        var actual = SumOfPowerClass.SumOfPower(nums);
        Assert.Equal(expected, actual);
    }
}
