namespace playground.UnitTest;

public class TwoSumTest_0167
{
    [Theory]
    [InlineData("[2,7,11,15]", 9, "[1,2]")]
    [InlineData("[2,7,11,15]", 26, "[3,4]")]
    [InlineData("[2,3,4]", 6, "[1,3]")]
    [InlineData("[-1,0]", -1, "[1,2]")]
    public void TwoSum(string A, int target, string expected)
    {
        var actual = TwoSum_0167.TwoSum(A.ToArr(), target);
        Assert.True(Enumerable.SequenceEqual(expected.ToArr(), actual));
    }
}
