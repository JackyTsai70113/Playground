namespace playground.UnitTest;

public class TwoSumTest0001
{
    [Theory]
    [InlineData("[2,7,11,15]", 9, "[1,0]")]
    [InlineData("[3,2,4]", 6, "[2,1]")]
    [InlineData("[3,3]", 6, "[1,0]")]
    public void TwoSum(string A, int target, string expected)
    {
        var actual = TwoSum0001.TwoSum(A.ToArr(), target);
        Assert.Equal(expected.ToArr(), actual);
    }
}
